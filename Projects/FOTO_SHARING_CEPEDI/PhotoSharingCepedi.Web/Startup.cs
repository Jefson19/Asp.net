using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhotoSharingCepedi.Web.Startup))]
namespace PhotoSharingCepedi.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
