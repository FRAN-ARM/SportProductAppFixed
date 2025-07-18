namespace SportProductApp.SportFlowCustomers {
    export interface CustomersOrdersForm {
        PublicId: Serenity.StringEditor;
        CustomerId: Serenity.IntegerEditor;
        Address: Serenity.StringEditor;
        DateCreated: Serenity.DateEditor;
        Status: Serenity.EnumEditor;
    }

    export class CustomersOrdersForm extends Serenity.PrefixedContext {
        static formKey = 'SportFlowCustomers.CustomersOrders';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!CustomersOrdersForm.init)  {
                CustomersOrdersForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.IntegerEditor;
                var w2 = s.DateEditor;
                var w3 = s.EnumEditor;

                Q.initFormType(CustomersOrdersForm, [
                    'PublicId', w0,
                    'CustomerId', w1,
                    'Address', w0,
                    'DateCreated', w2,
                    'Status', w3
                ]);
            }
        }
    }
}

