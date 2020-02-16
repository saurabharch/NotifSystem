using NotifSystem.Default.Entities;
using NotifSystem.Hubs;
using Serenity.Data;
using Serenity.Services;
using System.Web.Mvc;

namespace NotifSystem.Default.Endpoints
{
    [RoutePrefix("Services/Default/DemoNotification"), Route("{action}")]
    [Authorize]
    public class DemoNotificationController : ServiceEndpoint
    {
        [HttpPost]
        public ServiceResponse SendNotification(SendNotificationRequest request)
        {
            NotificationRow objNotif = new NotificationRow
            {
                SentTo = request.Username,
                Details = request.Message
            };

            using (var connection = SqlConnections.NewFor<NotificationRow>())
            {
                connection.Insert(objNotif);
            }

            NotificationHub objNotifHub = new NotificationHub();
            objNotifHub.SendNotification(objNotif.SentTo);

            //var query = (from t in context.Notifications
            //             select t).ToList();
            //return Request.CreateResponse(HttpStatusCode.OK, new { query });

            return new ServiceResponse { };
        }
    }
}