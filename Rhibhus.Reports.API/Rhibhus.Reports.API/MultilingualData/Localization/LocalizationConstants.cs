namespace Rhibhus.Reports.API.MultilingualData.Localization
{
    public static class LocalizationConstants
    {
        public static readonly LanguageCode[] SupportedLanguages = {
            new LanguageCode
            {
                Code = "en-US",
                DisplayName= "English"
            },
            new LanguageCode
            {
                Code = "de-DE",
                DisplayName = "German"
            },
            new LanguageCode
            {
                Code = "en-AU",
                DisplayName= "English"
            }
        };
    }
}
