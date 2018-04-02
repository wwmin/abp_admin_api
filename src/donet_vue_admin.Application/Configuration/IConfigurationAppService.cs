using System.Threading.Tasks;
using donet_vue_admin.Configuration.Dto;

namespace donet_vue_admin.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
