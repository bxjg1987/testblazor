using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace TestBlazorServer.Localization
{
    public static class TestBlazorServerLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(TestBlazorServerConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(TestBlazorServerLocalizationConfigurer).GetAssembly(),
                        "TestBlazorServer.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
