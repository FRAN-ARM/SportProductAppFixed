
namespace SportProductApp.SportFlowCustomers {

    @Serenity.Decorators.registerClass()
    export class CustomersOrdersGrid extends Serenity.EntityGrid<CustomersOrdersRow, any> {
        protected getColumnsKey() { return 'SportFlowCustomers.CustomersOrdersColumns'; }
        protected getDialogType() { return CustomersOrdersDialog; }
        protected getIdProperty() { return CustomersOrdersRow.idProperty; }
        protected getInsertPermission() { return CustomersOrdersRow.insertPermission; }
        protected getLocalTextPrefix() { return CustomersOrdersRow.localTextPrefix; }
        protected getService() { return CustomersOrdersService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        // Quitamos los botones que no queremos que el cliente use. Tambien agregamos.
        protected getButtons(): Serenity.ToolButton[] {
            let buttons = super.getButtons();
            buttons = buttons.filter(x => x.cssClass !== "add-button");
            buttons = buttons.filter(x => x.cssClass !== "column-picker-button");
            buttons.push(Common.PdfExportHelper.createToolButton({
                grid: this,
                onViewSubmit: () => this.onViewSubmit()
            }));
            return buttons;
        }
    }
}