using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using Elmah;
namespace ElmahDemo
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            try
            {
                throw new Exception();
            }
            catch(Exception ex)
            {
                ErrorLog.GetDefault(null).Log(new Error(ex));
                ErrorSignal.FromCurrentContext().Raise(ex);
            }
        }
    }
}