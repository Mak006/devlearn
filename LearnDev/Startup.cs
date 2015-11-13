using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LearnDev.Startup))]
namespace LearnDev
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
