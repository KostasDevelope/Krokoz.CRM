using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Krokoz.CRM.MVCClient.Startup))]
namespace Krokoz.CRM.MVCClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
