namespace SportProductApp.SportFlow {
    export interface OrdersForm {
        PublicId: Serenity.StringEditor;
        CustomerId: Serenity.IntegerEditor;
        Status: Serenity.StringEditor;
        Address: Serenity.StringEditor;
        DateCreated: Serenity.DateEditor;
    }

    export class OrdersForm extends Serenity.PrefixedContext {
        static formKey = 'SportFlow.Orders';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!OrdersForm.init)  {
                OrdersForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.IntegerEditor;
                var w2 = s.DateEditor;

                Q.initFormType(OrdersForm, [
                    'PublicId', w0,
                    'CustomerId', w1,
                    'Status', w0,
                    'Address', w0,
                    'DateCreated', w2
                ]);
            }
        }
    }
}

