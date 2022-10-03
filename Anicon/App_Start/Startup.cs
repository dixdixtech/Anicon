using Microsoft.Owin;
using Owin;
using System;
using Microsoft.Owin.Security.Cookies;
using System.Threading.Tasks;

[assembly: OwinStartup(typeof(Anicon.App_Start.Startup))]

namespace Anicon.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //app.UseCookieAuthentication(new CookieAuthenticationOptions
            //{
            //    AuthenticationType = "AppAplicationCookie",
            //    LoginPath = new PathString("Home/Login")
            //});
        }
    }
}
