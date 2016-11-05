using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Wordpractice_mvc.Startup))]
namespace Wordpractice_mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
