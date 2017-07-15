using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestSolution.Web.Startup))]
namespace TestSolution.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
