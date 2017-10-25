using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAzureLab.Startup))]
namespace WebAzureLab
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
