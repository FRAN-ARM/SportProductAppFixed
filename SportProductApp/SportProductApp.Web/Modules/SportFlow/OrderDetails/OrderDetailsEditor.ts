
namespace SportProductApp.SportFlow {

    @Serenity.Decorators.registerEditor("SportProductApp.SportFlow.OrderDetailsEditor")
    export class OrderDetailsEditor extends SportProductApp.Common.GridEditorBase<OrderDetailsRow> {

        protected getColumnsKey() { return "SportFlow.OrderDetails"; }
        protected getDialogType() { return OrderDetailsDialog; }
        protected getLocalTextPrefix() { return OrderDetailsRow.localTextPrefix; }
        protected getAddButtonCaption() { return "Agregar Producto"; }
        protected validateEntity(row: OrderDetailsRow, id: number): boolean {
            // Validar que el producto no esté duplicado
            if (!row.ProductId) {
                Q.alert("Debe seleccionar un producto.");
                return false;
            }

            // Evitar productos repetidos
            let same = Q.tryFirst(this.view.getItems(), x =>
                x.ProductId === row.ProductId && x !== row);

            if (same) {
                Q.alert("Este producto ya fue agregado.");
                return false;
            }

            // Asignar el nombre del producto al mostrarlo en la grilla
            row.ProductName = ProductsRow.getLookup().itemById[row.ProductId]?.Name;

            return true;
        }

        constructor(container: JQuery) {
            super(container);
        }
    }
}
