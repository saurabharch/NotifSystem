using Dapper;
using Microsoft.AspNet.SignalR;
using NotifSystem.Default.Entities;
using NotifSystem.Models;
using Serenity.Data;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NotifSystem.Hubs
{
    public class NotificationHub : Hub
    {
        private static readonly ConcurrentDictionary<string, UserHubModels> Users =
            new ConcurrentDictionary<string, UserHubModels>(StringComparer.InvariantCultureIgnoreCase);

        public void GetNotification()
        {
            try
            {
                string loggedUser = Context.User.Identity.Name;

                string nbrOfNotification = LoadNotifData(loggedUser);

                var context = GlobalHost.ConnectionManager.GetHubContext<NotificationHub>();
                context.Clients.User(loggedUser).broadcastNotification(nbrOfNotification);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        public void SendNotification(string sendToUserName)
        {
            try
            {
                string totalNotification = LoadNotifData(sendToUserName);

                var context = GlobalHost.ConnectionManager.GetHubContext<NotificationHub>();
                context.Clients.User(sendToUserName).broadcastNotification(totalNotification);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private string LoadNotifData(string username)
        {
            using (var connection = SqlConnections.NewFor<NotificationRow>())
            {
                var parms = new Dapper.DynamicParameters();
                parms.Add("@username", username);

                var total = connection.ExecuteScalar<int>($"SELECT COUNT(1) FROM dbo.Notification WHERE SentTo = @username", parms);

                return total.ToString();
            }
        }

        public override Task OnConnected()
        {
            string userName = Context.User.Identity.Name;
            string connectionId = Context.ConnectionId;

            var user = Users.GetOrAdd(userName, _ => new UserHubModels
            {
                UserName = userName,
                ConnectionIds = new HashSet<string>()
            });

            lock (user.ConnectionIds)
            {
                user.ConnectionIds.Add(connectionId);
                if (user.ConnectionIds.Count == 1)
                {
                    Clients.Others.userConnected(userName);
                }
            }

            return base.OnConnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            string userName = Context.User.Identity.Name;
            string connectionId = Context.ConnectionId;

            UserHubModels user;
            Users.TryGetValue(userName, out user);

            if (user != null)
            {
                lock (user.ConnectionIds)
                {
                    user.ConnectionIds.RemoveWhere(cid => cid.Equals(connectionId));
                    if (!user.ConnectionIds.Any())
                    {
                        UserHubModels removedUser;
                        Users.TryRemove(userName, out removedUser);
                        Clients.Others.userDisconnected(userName);
                    }
                }
            }

            return base.OnDisconnected(stopCalled);
        }
    }
}