namespace NotifSystem.Default {
    export interface NotificationForm {
        Type: Serenity.IntegerEditor;
        Details: Serenity.StringEditor;
        Title: Serenity.StringEditor;
        DetailsUrl: Serenity.StringEditor;
        SentTo: Serenity.StringEditor;
        Date: Serenity.DateEditor;
        IsRead: Serenity.BooleanEditor;
        IsDeleted: Serenity.BooleanEditor;
        IsReminder: Serenity.BooleanEditor;
        Code: Serenity.StringEditor;
        NotificationType: Serenity.StringEditor;
    }

    export class NotificationForm extends Serenity.PrefixedContext {
        static formKey = 'Default.Notification';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!NotificationForm.init)  {
                NotificationForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.StringEditor;
                var w2 = s.DateEditor;
                var w3 = s.BooleanEditor;

                Q.initFormType(NotificationForm, [
                    'Type', w0,
                    'Details', w1,
                    'Title', w1,
                    'DetailsUrl', w1,
                    'SentTo', w1,
                    'Date', w2,
                    'IsRead', w3,
                    'IsDeleted', w3,
                    'IsReminder', w3,
                    'Code', w1,
                    'NotificationType', w1
                ]);
            }
        }
    }
}

