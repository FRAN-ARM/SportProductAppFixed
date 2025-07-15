
namespace SportProductApp.SportFlow {

    @Serenity.Decorators.registerClass()
    export class CustomersDialog extends Serenity.EntityDialog<CustomersRow, any> {
        protected getFormKey() { return CustomersForm.formKey; }
        protected getIdProperty() { return CustomersRow.idProperty; }
        protected getLocalTextPrefix() { return CustomersRow.localTextPrefix; }
        protected getNameProperty() { return CustomersRow.nameProperty; }
        protected getService() { return CustomersService.baseUrl; }
        protected getDeletePermission() { return CustomersRow.deletePermission; }
        protected getInsertPermission() { return CustomersRow.insertPermission; }
        protected getUpdatePermission() { return CustomersRow.updatePermission; }

        protected form = new CustomersForm(this.idPrefix);

        protected afterLoadEntity() {
            super.afterLoadEntity();

            if (this.isNew()) {
                const today = Q.formatDate(new Date(), "yyyy/MM/dd");
                this.form.DateCreated.value = today;
            }
        }

    }
}