namespace SportProductApp.SportFlow {
    export interface OrderDetailsForm {
        OrderId: Serenity.LookupEditor;
        ProductId: Serenity.LookupEditor;
        Quantity: Serenity.IntegerEditor;
        PriceSnapshot: Serenity.DecimalEditor;
    }

    export class OrderDetailsForm extends Serenity.PrefixedContext {
        static formKey = 'SportFlow.OrderDetailsForm';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!OrderDetailsForm.init)  {
                OrderDetailsForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;
                var w1 = s.IntegerEditor;
                var w2 = s.DecimalEditor;

                Q.initFormType(OrderDetailsForm, [
                    'OrderId', w0,
                    'ProductId', w0,
                    'Quantity', w1,
                    'PriceSnapshot', w2
                ]);
            }
        }
    }
}

