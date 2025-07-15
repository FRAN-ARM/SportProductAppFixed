namespace SportProductApp.SportFlow {
    export interface ProductsForm {
        PublicId: Serenity.StringEditor;
        Name: Serenity.StringEditor;
        Price: Serenity.DecimalEditor;
        DateCreated: Serenity.DateEditor;
    }

    export class ProductsForm extends Serenity.PrefixedContext {
        static formKey = 'SportFlow.Products';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ProductsForm.init)  {
                ProductsForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DecimalEditor;
                var w2 = s.DateEditor;

                Q.initFormType(ProductsForm, [
                    'PublicId', w0,
                    'Name', w0,
                    'Price', w1,
                    'DateCreated', w2
                ]);
            }
        }
    }
}

