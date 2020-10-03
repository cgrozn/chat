using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CagriSignalR.Startup))]
namespace CagriSignalR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}