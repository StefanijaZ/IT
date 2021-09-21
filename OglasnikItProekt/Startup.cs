using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OglasnikItProekt.Startup))]
namespace OglasnikItProekt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
