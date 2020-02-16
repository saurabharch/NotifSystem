using Serenity.Services;

namespace NotifSystem.Default
{
    public class SendNotificationRequest: ServiceRequest
    {
        public string Username { get; set; }
        public string Message { get; set; }
    }
}