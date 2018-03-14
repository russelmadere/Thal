using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Thal.Startup))]
namespace Thal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
