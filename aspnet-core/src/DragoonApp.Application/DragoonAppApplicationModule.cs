using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DragoonApp.Authorization;

namespace DragoonApp
{
    [DependsOn(
        typeof(DragoonAppCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class DragoonAppApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<DragoonAppAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(DragoonAppApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
