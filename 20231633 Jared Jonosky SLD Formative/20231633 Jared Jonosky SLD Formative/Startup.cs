using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_20231633_Jared_Jonosky_SLD_Formative.Startup))]
namespace _20231633_Jared_Jonosky_SLD_Formative
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
