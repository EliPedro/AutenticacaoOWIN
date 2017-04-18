using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Google;

namespace OwinAuthentication
{
    public partial class Startup
    {
        private void ConfigureAuth(IAppBuilder app)
        {
            app.MapSignalR();

            var cookieOptions = new CookieAuthenticationOptions
            {
                LoginPath = new PathString("/Account/Login")
            };

            app.UseCookieAuthentication(cookieOptions);

            app.SetDefaultSignInAsAuthenticationType(cookieOptions.AuthenticationType);

            app.UseGoogleAuthentication(new GoogleOAuth2AuthenticationOptions
            {
                ClientId = "713668382610-k78pothi94ohd6jj0ha6fj2kopc3u1lc.apps.googleusercontent.com",
                ClientSecret = "xtqVIrE5U992a_fUGcSjg4I0"
            });

            app.UseFacebookAuthentication(
             appId: "000000000000000",
             appSecret: "000000000000000");

            app.UseMicrosoftAccountAuthentication(
            clientId: "426f62526f636b73",
            clientSecret: "57686f6120447564652c2049495320526f636b73");

        }
    }
}
