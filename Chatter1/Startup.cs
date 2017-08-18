using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Chatter1.Startup))]
namespace Chatter1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
