using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VuDinhPhong_Lab3.Startup))]
namespace VuDinhPhong_Lab3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
