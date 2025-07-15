
namespace SportProductApp.Places {

    @Serenity.Decorators.registerClass()
    export class ProvincesDialog extends Serenity.EntityDialog<ProvincesRow, any> {
        protected getFormKey() { return ProvincesForm.formKey; }
        protected getIdProperty() { return ProvincesRow.idProperty; }
        protected getLocalTextPrefix() { return ProvincesRow.localTextPrefix; }
        protected getNameProperty() { return ProvincesRow.nameProperty; }
        protected getService() { return ProvincesService.baseUrl; }
        protected getDeletePermission() { return ProvincesRow.deletePermission; }
        protected getInsertPermission() { return ProvincesRow.insertPermission; }
        protected getUpdatePermission() { return ProvincesRow.updatePermission; }

        protected form = new ProvincesForm(this.idPrefix);

    }
}