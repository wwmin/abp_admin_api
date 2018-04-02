using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace donet_vue_admin.Localization
{
    public static class donet_vue_adminLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(donet_vue_adminConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(donet_vue_adminLocalizationConfigurer).GetAssembly(),
                        "donet_vue_admin.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
