namespace SportProductApp.Places {
    export interface ProvincesForm {
        Name: Serenity.StringEditor;
    }

    export class ProvincesForm extends Serenity.PrefixedContext {
        static formKey = 'Places.Provinces';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ProvincesForm.init)  {
                ProvincesForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(ProvincesForm, [
                    'Name', w0
                ]);
            }
        }
    }
}

