namespace NotifSystem.Default {
    export interface NotificationRow {
        Id?: number;
        Type?: number;
        Details?: string;
        Title?: string;
        DetailsUrl?: string;
        SentTo?: string;
        Date?: string;
        IsRead?: boolean;
        IsDeleted?: boolean;
        IsReminder?: boolean;
        Code?: string;
        NotificationType?: string;
    }

    export namespace NotificationRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Details';
        export const localTextPrefix = 'Default.Notification';
        export const deletePermission = 'Administration:General';
        export const insertPermission = 'Administration:General';
        export const readPermission = 'Administration:General';
        export const updatePermission = 'Administration:General';

        export declare const enum Fields {
            Id = "Id",
            Type = "Type",
            Details = "Details",
            Title = "Title",
            DetailsUrl = "DetailsUrl",
            SentTo = "SentTo",
            Date = "Date",
            IsRead = "IsRead",
            IsDeleted = "IsDeleted",
            IsReminder = "IsReminder",
            Code = "Code",
            NotificationType = "NotificationType"
        }
    }
}

