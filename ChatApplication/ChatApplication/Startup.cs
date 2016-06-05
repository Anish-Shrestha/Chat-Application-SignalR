using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Signar2.Startup))]
namespace Signar2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
