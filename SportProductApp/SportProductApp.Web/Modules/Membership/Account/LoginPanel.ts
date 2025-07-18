namespace SportProductApp.Membership {

    @Serenity.Decorators.registerClass()
    export class LoginPanel extends Serenity.PropertyPanel<LoginRequest, any> {

        protected getFormKey() { return LoginForm.formKey; }

        constructor(container: JQuery) {
            super(container);

            this.byId('LoginButton').click(e => {
                e.preventDefault();

                if (!this.validateForm()) {
                    return;
                }

                var request = this.getSaveEntity();

                Q.serviceCall({
                    url: Q.resolveUrl('~/Account/Login'),
                    request: request,
                    onSuccess: (response: any) => {
                        if (response.RedirectPath) {
                            window.location.href = Q.resolveUrl(response.RedirectPath);
                        } else {
                            this.redirectToReturnUrl();
                        }
                        this.redirectToReturnUrl();
                    },
                    onError: (response: Serenity.ServiceResponse) => {
                        if (response != null && response.Error != null && response.Error.Code == "RedirectUserTo") {
                            window.location.href = response.Error.Arguments;
                            return;
                        }

                        if (response != null && response.Error != null && !Q.isEmptyOrNull(response.Error.Message)) {
                            Q.notifyError(response.Error.Message);
                            $('#Password').focus();

                            return;
                        }

                        Q.ErrorHandling.showServiceError(response.Error);
                    }
                });
            });
        }

        protected redirectToReturnUrl() {
            var q = Q.parseQueryString();
            var returnUrl = q['returnUrl'] || q['ReturnUrl'];
            if (returnUrl) {
                var hash = window.location.hash;
                if (hash != null && hash != '#')
                    returnUrl += hash;
                window.location.href = returnUrl;
            }
            else {
                window.location.href = Q.resolveUrl('~/');
            }
        }

        protected getTemplate() {
            return `
<div class="flex-layout">
    <div class="logo"></div>
    <h3>${Q.text("Forms.Membership.Login.FormTitle")}</h3>
    <form id="~_Form" action="">
        <div class="s-Form">
            <div class="fieldset ui-widget ui-widget-content ui-corner-all">
                <div id="~_PropertyGrid"></div>
                <div class="clear"></div>
            </div>
            <div class="buttons">
                <button id="~_LoginButton" type="submit" class="btn btn-primary">
                    ${Q.text("Forms.Membership.Login.SignInButton")}
                </button>
            </div>
            <div class="actions">
                <a href="${Q.resolveUrl('~/Account/ForgotPassword')}"><i class="fa fa-angle-right"></i>&nbsp;${Q.text("Forms.Membership.Login.ForgotPassword")}</a>
                <a href="${Q.resolveUrl('~/Account/SignUp')}"><i class="fa fa-angle-right"></i>&nbsp;${Q.text("Forms.Membership.Login.SignUpButton")}</a>
                <div class="clear"></div>
            </div>
        </div>
    </form>
</div>
`;
        }
    }
}