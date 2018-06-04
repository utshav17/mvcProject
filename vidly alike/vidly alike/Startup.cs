using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(vidly_alike.Startup))]
namespace vidly_alike
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
