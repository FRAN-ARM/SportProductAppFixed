namespace SportProductApp.SportFlow {
    export interface OrderDetailsForm {
        OrderId: Serenity.IntegerEditor;
        ProductId: Serenity.IntegerEditor;
        Quantity: Serenity.IntegerEditor;
        PriceSnapshot: Serenity.DecimalEditor;
    }

    export class OrderDetailsForm extends Serenity.PrefixedContext {
        static formKey = 'SportFlow.OrderDetails';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!OrderDetailsForm.init)  {
                OrderDetailsForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.DecimalEditor;

                Q.initFormType(OrderDetailsForm, [
                    'OrderId', w0,
                    'ProductId', w0,
                    'Quantity', w0,
                    'PriceSnapshot', w1
                ]);
            }
        }
    }
}

