using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_8020SummativePRG522.Startup))]
namespace _8020SummativePRG522
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
