
namespace SportProductApp.Places {

    @Serenity.Decorators.registerClass()
    export class ProvincesGrid extends Serenity.EntityGrid<ProvincesRow, any> {
        protected getColumnsKey() { return 'Places.ProvincesColumns'; }
        protected getDialogType() { return ProvincesDialog; }
        protected getIdProperty() { return ProvincesRow.idProperty; }
        protected getInsertPermission() { return ProvincesRow.insertPermission; }
        protected getLocalTextPrefix() { return ProvincesRow.localTextPrefix; }
        protected getService() { return ProvincesService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getButtons(): Serenity.ToolButton[] {
            let buttons = super.getButtons();
            buttons.push(Common.PdfExportHelper.createToolButton({
                grid: this,
                onViewSubmit: () => this.onViewSubmit()
            }));
            return buttons;
        }
    }
}