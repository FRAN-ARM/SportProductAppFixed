/// <reference path="../../Common/Helpers/GridEditorBase.ts" />

namespace SportProductApp.SportFlow {

    @Serenity.Decorators.registerClass()
    export class OrderDetailsEditor extends Common.GridEditorBase<OrderDetailsRow> {

        protected getColumnsKey() { return "SportFlow.OrderDetailsColumns"; }
        protected getDialogType() { return OrderDetailsDialog; }
        protected getLocalTextPrefix() { return OrderDetailsRow.localTextPrefix; }
        protected getAddButtonCaption() { return "Add Product"; }

        // Chequeos importantes.
        protected validateEntity(row: OrderDetailsRow, id: number): boolean {

            // Validar que el producto no esté duplicado.
            if (!row.ProductId) {
                Q.alert("Select a product.");
                return false;
            }

            // Evitar productos repetidos.
            let same = Q.tryFirst(this.view.getItems(), x =>
                x.ProductId === row.ProductId && x !== row);
            if (same) {
                Q.alert("This product has already been added.");
                return false;
            }

            // Asignar el nombre del producto al mostrarlo.
            row.ProductName = ProductsRow.getLookup().itemById[row.ProductId]?.Name;

            // Obtener total de la cantidad de precios por productos.
            row.Total = (row.Quantity || 0) * (row.PriceSnapshot || 0);

            return true;
        }

        constructor(container: JQuery) {
            super(container);
        }
    }
}
