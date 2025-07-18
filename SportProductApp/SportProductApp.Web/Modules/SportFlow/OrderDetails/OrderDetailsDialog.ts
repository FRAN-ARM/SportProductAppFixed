/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace SportProductApp.SportFlow {

    @Serenity.Decorators.registerClass()
    export class OrderDetailsDialog extends Serenity.EntityDialog<OrderDetailsRow, any> {
        protected getFormKey() { return OrderDetailsForm.formKey; }
        protected getIdProperty() { return OrderDetailsRow.idProperty; }
        protected getLocalTextPrefix() { return OrderDetailsRow.localTextPrefix; }
        protected getService() { return OrderDetailsService.baseUrl; }
        protected getDeletePermission() { return OrderDetailsRow.deletePermission; }
        protected getInsertPermission() { return OrderDetailsRow.insertPermission; }
        protected getUpdatePermission() { return OrderDetailsRow.updatePermission; }
        public embedded: boolean = false;
        public embeddedOrderId: string = "";
        protected form: OrderDetailsForm;
        constructor() {
            super();
            this.form = new OrderDetailsForm(this.idPrefix);

            // Para actualizar Price una vez se selecciona un nuevo producto.
            this.form.ProductId.changeSelect2(e => {
                var productID = Q.toId(this.form.ProductId.value);
                if (productID != null) {
                    this.form.PriceSnapshot.value = ProductsRow.getLookup().itemById[productID].Price;
                }
            });

        }
    }
}