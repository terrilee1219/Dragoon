using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using DragoonApp.Configuration.Dto;

namespace DragoonApp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : DragoonAppAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
