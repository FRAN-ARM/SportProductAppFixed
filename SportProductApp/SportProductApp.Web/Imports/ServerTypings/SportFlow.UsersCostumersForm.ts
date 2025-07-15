namespace SportProductApp.SportFlow {
    export interface UsersCostumersForm {
        Username: Serenity.StringEditor;
        DisplayName: Serenity.StringEditor;
        Email: Serenity.StringEditor;
    }

    export class UsersCostumersForm extends Serenity.PrefixedContext {
        static formKey = 'SportFlow.UsersCostumers';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!UsersCostumersForm.init)  {
                UsersCostumersForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(UsersCostumersForm, [
                    'Username', w0,
                    'DisplayName', w0,
                    'Email', w0
                ]);
            }
        }
    }
}

