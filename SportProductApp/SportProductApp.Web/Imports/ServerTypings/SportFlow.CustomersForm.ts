namespace SportProductApp.SportFlow {
    export interface CustomersForm {
        UserUsername: Serenity.StringEditor;
        UserDisplayName: Serenity.StringEditor;
        UserEmail: Serenity.EmailEditor;
        CreditCard: Serenity.StringEditor;
        DateCreated: Serenity.DateEditor;
    }

    export class CustomersForm extends Serenity.PrefixedContext {
        static formKey = 'SportFlow.CustomersForm';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!CustomersForm.init)  {
                CustomersForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.EmailEditor;
                var w2 = s.DateEditor;

                Q.initFormType(CustomersForm, [
                    'UserUsername', w0,
                    'UserDisplayName', w0,
                    'UserEmail', w1,
                    'CreditCard', w0,
                    'DateCreated', w2
                ]);
            }
        }
    }
}

