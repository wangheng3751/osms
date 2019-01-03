using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using OSMS.Authorization;

namespace OSMS
{
    [DependsOn(
        typeof(OSMSCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class OSMSApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<OSMSAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(OSMSApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
