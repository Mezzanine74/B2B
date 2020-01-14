using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(B2B.WebMVC.Startup))]
namespace B2B.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}