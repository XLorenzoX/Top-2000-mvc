using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Top_2000.Startup))]
namespace Top_2000
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
