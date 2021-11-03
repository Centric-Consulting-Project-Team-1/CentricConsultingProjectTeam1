using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CentricConsultingProjectTeam1.Startup))]
namespace CentricConsultingProjectTeam1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
