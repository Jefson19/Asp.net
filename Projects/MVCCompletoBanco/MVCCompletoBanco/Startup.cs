using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCCompletoBanco.Startup))]
namespace MVCCompletoBanco
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
