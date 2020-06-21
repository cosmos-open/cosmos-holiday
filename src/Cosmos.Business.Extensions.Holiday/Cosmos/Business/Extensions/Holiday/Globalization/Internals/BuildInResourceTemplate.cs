using System.Collections.Generic;
using System.Linq;

namespace Cosmos.Business.Extensions.Holiday.Globalization.Internals
{
    /// <summary>
    /// Build-in resource template
    /// </summary>
    public class BuildInResourceTemplate
    {
        /// <summary>
        /// Country
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// Belongs to country
        /// </summary>
        public string BelongsToCountry { get; set; }

        /// <summary>
        /// Country Alias like China as cn
        /// </summary>
        public string Alias { get; set; }

        /// <summary>
        /// Language tag
        /// </summary>
        public string LangTag { get; set; }

        /// <summary>
        /// Default?
        /// </summary>
        public bool Default { get; set; }

        /// <summary>
        /// Data
        /// </summary>
        public List<BuildInResourceItem> Data { get; set; }

        /// <summary>
        /// Try get text
        /// </summary>
        /// <param name="code"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public bool TryGetText(string code, out string text)
        {
            if (string.IsNullOrWhiteSpace(code))
            {
                text = default;
                return false;
            }

            if (Data == null)
            {
                text = default;
                return false;
            }

            var _ = Data.FirstOrDefault(x => x.Code == code);

            if (_ == null)
            {
                text = default;
                return false;
            }

            text = _.Text;
            return true;
        }

        /// <summary>
        /// Try get text
        /// </summary>
        /// <param name="key"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public bool TryGetTextByGKey(string key, out string text)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                text = default;
                return false;
            }

            if (Data == null)
            {
                text = default;
                return false;
            }

            var _ = Data.FirstOrDefault(x => x.GKey == key);

            if (_ == null)
            {
                text = default;
                return false;
            }

            text = _.Text;
            return true;
        }
    }


    /// <summary>
    /// Build-in resource data item
    /// </summary>
    public class BuildInResourceItem
    {
        /// <summary>
        /// I18N Code
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Date
        /// </summary>
        public string GKey { get; set; }

        /// <summary>
        /// Text
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Has i18n code
        /// </summary>
        /// <returns></returns>
        public bool HasI18NCode() => !string.IsNullOrWhiteSpace(Code);

        /// <summary>
        /// Has date globalization key
        /// </summary>
        /// <returns></returns>
        public bool HasDateGlobalizationKey() => !string.IsNullOrWhiteSpace(GKey);

        /// <summary>
        /// Is match code
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public bool IsMatchCode(string code) => HasI18NCode() && Code == code;

        /// <summary>
        /// Is match date
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public bool IsMatchKey(string date) => HasDateGlobalizationKey() && GKey == date;
    }
}