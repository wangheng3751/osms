using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using OSMS.Configuration.Dto;

namespace OSMS.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : OSMSAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
