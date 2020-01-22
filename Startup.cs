using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ah799415MIS4200.Startup))]
namespace ah799415MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
