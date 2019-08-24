using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Eshtrexo.Startup))]
namespace Eshtrexo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
