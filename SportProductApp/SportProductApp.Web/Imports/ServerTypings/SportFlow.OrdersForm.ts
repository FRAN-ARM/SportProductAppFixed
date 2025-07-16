namespace SportProductApp.SportFlow {
    export interface OrdersForm {
        PublicId: Serenity.StringEditor;
        CustomerId: Serenity.IntegerEditor;
        Status: Serenity.EnumEditor;
        ProvinceId: Serenity.LookupEditor;
        CityId: Serenity.LookupEditor;
        ItemList: OrderDetailsEditor;
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
                var w2 = s.EnumEditor;
                var w3 = s.LookupEditor;
                var w4 = OrderDetailsEditor;
                var w5 = s.DateEditor;

                Q.initFormType(OrdersForm, [
                    'PublicId', w0,
                    'CustomerId', w1,
                    'Status', w2,
                    'ProvinceId', w3,
                    'CityId', w3,
                    'ItemList', w4,
                    'DateCreated', w5
                ]);
            }
        }
    }
}

