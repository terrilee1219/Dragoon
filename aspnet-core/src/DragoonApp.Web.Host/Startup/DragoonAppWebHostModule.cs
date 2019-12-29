using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DragoonApp.Configuration;

namespace DragoonApp.Web.Host.Startup
{
    [DependsOn(
       typeof(DragoonAppWebCoreModule))]
    public class DragoonAppWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public DragoonAppWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DragoonAppWebHostModule).GetAssembly());
        }
    }
}
