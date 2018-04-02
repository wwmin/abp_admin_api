using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using donet_vue_admin.Configuration.Dto;

namespace donet_vue_admin.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : donet_vue_adminAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
