
namespace NotifSystem.Default {

    export class NotificationHelper  {

        public Send(username: string, msg: string, callback?: (res: Serenity.ServiceResponse) => void) {
            DemoNotificationService.SendNotification({ Username: username, Message: msg }, response => {
                callback && callback(response);
            });
        }
    }
}