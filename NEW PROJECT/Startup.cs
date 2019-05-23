using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NEW_PROJECT.Startup))]
namespace NEW_PROJECT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
