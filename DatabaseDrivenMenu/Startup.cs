using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DatabaseDrivenMenu.Startup))]
namespace DatabaseDrivenMenu
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
