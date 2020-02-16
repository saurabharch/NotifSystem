
namespace NotifSystem.Default {

    @Serenity.Decorators.registerClass()
    export class NotificationDialog extends Serenity.EntityDialog<NotificationRow, any> {
        protected getFormKey() { return NotificationForm.formKey; }
        protected getIdProperty() { return NotificationRow.idProperty; }
        protected getLocalTextPrefix() { return NotificationRow.localTextPrefix; }
        protected getNameProperty() { return NotificationRow.nameProperty; }
        protected getService() { return NotificationService.baseUrl; }
        protected getDeletePermission() { return NotificationRow.deletePermission; }
        protected getInsertPermission() { return NotificationRow.insertPermission; }
        protected getUpdatePermission() { return NotificationRow.updatePermission; }

        protected form = new NotificationForm(this.idPrefix);

    }
}