using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DotNetRedeSociais1.Startup))]
namespace DotNetRedeSociais1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
