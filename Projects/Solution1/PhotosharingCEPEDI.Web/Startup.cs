using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PhotosharingCEPEDI.Web.Startup))]
namespace PhotosharingCEPEDI.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
