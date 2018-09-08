using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TimeSheetApp.Startup))]
namespace TimeSheetApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
