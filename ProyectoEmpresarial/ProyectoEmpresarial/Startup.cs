using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProyectoEmpresarial.Startup))]
namespace ProyectoEmpresarial
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
