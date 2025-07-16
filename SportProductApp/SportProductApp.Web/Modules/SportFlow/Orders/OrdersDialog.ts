
namespace SportProductApp.SportFlow {

    @Serenity.Decorators.registerClass()
    export class OrdersDialog extends Serenity.EntityDialog<OrdersRow, any> {
        protected getFormKey() { return OrdersForm.formKey; }
        protected getIdProperty() { return OrdersRow.idProperty; }
        protected getLocalTextPrefix() { return OrdersRow.localTextPrefix; }
        protected getNameProperty() { return OrdersRow.nameProperty; }
        protected getService() { return OrdersService.baseUrl; }
        protected getDeletePermission() { return OrdersRow.deletePermission; }
        protected getInsertPermission() { return OrdersRow.insertPermission; }
        protected getUpdatePermission() { return OrdersRow.updatePermission; }

        protected form = new OrdersForm(this.idPrefix);

        protected afterLoadEntity() {
            super.afterLoadEntity();

            if (this.isNew()) {
                const today = Q.formatDate(new Date(), "yyyy/MM/dd");
                this.form.DateCreated.value = today;
                this.form.PublicId.value = "ORD";
                this.form.Address.value = "DIR";
            }
        }
    }
}