namespace SportProductApp.Places {

    @Serenity.Decorators.registerClass()
    export class CitiesGrid extends Serenity.EntityGrid<CitiesRow, any> {
        protected getColumnsKey() { return 'Places.CitiesColumns'; }
        protected getDialogType() { return CitiesDialog; }
        protected getIdProperty() { return CitiesRow.idProperty; }
        protected getInsertPermission() { return CitiesRow.insertPermission; }
        protected getLocalTextPrefix() { return CitiesRow.localTextPrefix; }
        protected getService() { return CitiesService.baseUrl; }

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