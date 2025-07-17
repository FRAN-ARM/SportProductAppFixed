
namespace SportProductApp.SportFlow {

    @Serenity.Decorators.registerClass()
    export class OrderDetailsGrid extends Serenity.EntityGrid<OrderDetailsRow, any> {
        protected getColumnsKey() { return 'SportFlow.OrderDetailsColumns'; }
        protected getDialogType() { return OrderDetailsDialog; }
        protected getIdProperty() { return OrderDetailsRow.idProperty; }
        protected getInsertPermission() { return OrderDetailsRow.insertPermission; }
        protected getLocalTextPrefix() { return OrderDetailsRow.localTextPrefix; }
        protected getService() { return OrderDetailsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}