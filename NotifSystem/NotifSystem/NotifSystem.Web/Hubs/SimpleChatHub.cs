﻿using Microsoft.AspNet.SignalR;

namespace NotifSystem.Hubs
{
    public class SimpleChatHub : Hub
    {
        public void Send(string name, string message)
        {
            // Call the broadcastMessage method to update clients.
            Clients.All.broadcastMessage(name, message);
        }
    }
}