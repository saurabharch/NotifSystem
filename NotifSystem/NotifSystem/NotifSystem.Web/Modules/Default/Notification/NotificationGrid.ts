
namespace NotifSystem.Default {

    @Serenity.Decorators.registerClass()
    export class NotificationGrid extends Serenity.EntityGrid<NotificationRow, any> {
        protected getColumnsKey() { return 'Default.Notification'; }
        protected getDialogType() { return NotificationDialog; }
        protected getIdProperty() { return NotificationRow.idProperty; }
        protected getInsertPermission() { return NotificationRow.insertPermission; }
        protected getLocalTextPrefix() { return NotificationRow.localTextPrefix; }
        protected getService() { return NotificationService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}