using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JKCS.ML.POC.Startup))]
namespace JKCS.ML.POC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
