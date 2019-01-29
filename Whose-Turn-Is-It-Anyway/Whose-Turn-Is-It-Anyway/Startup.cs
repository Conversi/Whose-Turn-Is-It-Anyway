using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Whose_Turn_Is_It_Anyway.Startup))]
namespace Whose_Turn_Is_It_Anyway
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
