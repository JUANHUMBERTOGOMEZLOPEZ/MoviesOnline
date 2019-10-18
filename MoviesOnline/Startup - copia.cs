using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoviesOnline.Startup))]
namespace MoviesOnline
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
