using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using EasyIngresso.WEB.App_Start;


namespace EasyIngresso.WEB
{
    public class Global : HttpApplication
    {
        protected void Application_Start()
        {            
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_AuthenticateRequest(Object sender, EventArgs e)
        {
            //AuthenticationConfig(this.Context);
        }


    }
}
