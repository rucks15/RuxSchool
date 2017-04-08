using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShoolUI.Startup))]
namespace ShoolUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
