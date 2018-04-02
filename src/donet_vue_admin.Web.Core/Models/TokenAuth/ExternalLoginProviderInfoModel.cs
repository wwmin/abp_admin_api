using Abp.AutoMapper;
using donet_vue_admin.Authentication.External;

namespace donet_vue_admin.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
