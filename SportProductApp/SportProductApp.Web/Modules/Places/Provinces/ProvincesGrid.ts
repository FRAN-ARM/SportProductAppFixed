
namespace SportProductApp.Places {

    @Serenity.Decorators.registerClass()
    export class ProvincesGrid extends Serenity.EntityGrid<ProvincesRow, any> {
        protected getColumnsKey() { return 'Places.Provinces'; }
        protected getDialogType() { return ProvincesDialog; }
        protected getIdProperty() { return ProvincesRow.idProperty; }
        protected getInsertPermission() { return ProvincesRow.insertPermission; }
        protected getLocalTextPrefix() { return ProvincesRow.localTextPrefix; }
        protected getService() { return ProvincesService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}