using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AMDB.Startup))]
namespace AMDB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
