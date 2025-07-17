namespace SportProductApp.Places {
    export interface CitiesForm {
        ProvinceId: Serenity.IntegerEditor;
        Name: Serenity.StringEditor;
    }

    export class CitiesForm extends Serenity.PrefixedContext {
        static formKey = 'Places.CitiesForm';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!CitiesForm.init)  {
                CitiesForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.StringEditor;

                Q.initFormType(CitiesForm, [
                    'ProvinceId', w0,
                    'Name', w1
                ]);
            }
        }
    }
}

