namespace SportProductApp.SportFlow {
    export interface OrdersForm {
        PublicId: Serenity.StringEditor;
        CustomerId: Serenity.LookupEditor;
        Status: Serenity.EnumEditor;
        Address: Serenity.StringEditor;
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
                var w1 = s.LookupEditor;
                var w2 = s.EnumEditor;
                var w3 = OrderDetailsEditor;
                var w4 = s.DateEditor;

                Q.initFormType(OrdersForm, [
                    'PublicId', w0,
                    'CustomerId', w1,
                    'Status', w2,
                    'Address', w0,
                    'ProvinceId', w1,
                    'CityId', w1,
                    'ItemList', w3,
                    'DateCreated', w4
                ]);
            }
        }
    }
}

