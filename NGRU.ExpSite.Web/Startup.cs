using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NGRU.ExpSite.Web.Startup))]
namespace NGRU.ExpSite.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
			ConfigureUnity(app);
        }

	  
    }
}
