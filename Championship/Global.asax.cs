using Championship.AutoMapper;
using System.Web.Http;

namespace Championship
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AutoMapperConfig.RegisterMappings();
            ContainerConfig.Configure();
        }
    }
}
