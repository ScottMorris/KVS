using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KVS.Startup))]
namespace KVS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
