using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoneyTemplate.Startup))]
namespace MoneyTemplate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
