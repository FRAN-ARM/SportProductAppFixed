
namespace SportProductApp.SportFlowCustomers {

    @Serenity.Decorators.registerClass()
    export class CustomersOrdersDialog extends Serenity.EntityDialog<CustomersOrdersRow, any> {
        protected getFormKey() { return CustomersOrdersForm.formKey; }
        protected getIdProperty() { return CustomersOrdersRow.idProperty; }
        protected getLocalTextPrefix() { return CustomersOrdersRow.localTextPrefix; }
        protected getNameProperty() { return CustomersOrdersRow.nameProperty; }
        protected getService() { return CustomersOrdersService.baseUrl; }
        protected getDeletePermission() { return CustomersOrdersRow.deletePermission; }
        protected getInsertPermission() { return CustomersOrdersRow.insertPermission; }
        protected getUpdatePermission() { return CustomersOrdersRow.updatePermission; }

        protected form = new CustomersOrdersForm(this.idPrefix);

    }
}