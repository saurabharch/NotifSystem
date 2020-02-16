namespace NotifSystem.Default {
    export interface SendNotificationRequest extends Serenity.ServiceRequest {
        Username?: string;
        Message?: string;
    }
}

