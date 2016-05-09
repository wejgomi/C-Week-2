using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FootballDB.Startup))]
namespace FootballDB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
