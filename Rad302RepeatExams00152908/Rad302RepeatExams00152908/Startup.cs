using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Rad302RepeatExams00152908.Startup))]
namespace Rad302RepeatExams00152908
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
