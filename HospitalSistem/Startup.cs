using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HospitalSistem.Startup))]
namespace HospitalSistem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
