using System;
using EnumsNET;

namespace Cosmos.Business.Extensions.Holiday.Globalization
{
    /// <summary>
    /// Pure translation text
    /// </summary>
    public class PureTranslationText
    {
        /// <summary>
        /// Create a new instance of <see cref="PureTranslationText"/>
        /// </summary>
        /// <param name="lang"></param>
        /// <param name="text"></param>
        /// <param name="type"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public PureTranslationText(string lang, string text, ResourceType type)
        {
            if (string.IsNullOrWhiteSpace(lang))
                throw new ArgumentNullException(nameof(lang));

            LanguageAlias = lang;
            Text = text;
            Type = type;
        }

        //todo public LanguageTag Language{get;set;}

        /// <summary>
        /// Language Alias
        /// </summary>
        public string LanguageAlias { get; set; }

        /// <summary>
        /// Raw text of this pure translation text
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Resource type
        /// </summary>
        public ResourceType Type { get; set; }

        /// <summary>
        /// IsMatch
        /// </summary>
        /// <param name="languageAlias"></param>
        /// <returns></returns>
        public bool IsMatch(string languageAlias)
        {
            if (string.IsNullOrWhiteSpace(languageAlias))
                return false;

            if (string.Compare(LanguageAlias, languageAlias.Trim(), StringComparison.OrdinalIgnoreCase) == 0)
                return true;

            return false;
        }

        /// <summary>
        /// IsMatch
        /// </summary>
        /// <param name="languageAlias"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public bool IsMatch(string languageAlias, ResourceType type)
        {
            if (string.IsNullOrWhiteSpace(languageAlias))
                return false;

            if (string.Compare(LanguageAlias, languageAlias.Trim(), StringComparison.OrdinalIgnoreCase) == 0)
                return IsMatchType(type);

            return false;
        }

        private bool IsMatchType(ResourceType type)
        {
            return Type.HasAnyFlags(type);
        }

        //todo Is Match by language tag
    }
}