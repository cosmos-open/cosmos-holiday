using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Globalization.Internals;

namespace Cosmos.Business.Extensions.Holiday.Globalization.Strategy.BuildInStrategies
{
    /// <summary>
    /// Build-in i18n search strategy
    /// </summary>
    public class BuildInI18NSearchStrategy : ISearchStrategy
    {
        /// <summary>
        /// Try get text
        /// </summary>
        /// <param name="holidayDefinition"></param>
        /// <param name="languageTag"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public bool TryGetText(IHolidayFunc holidayDefinition, string languageTag, out string text)
        {
            if (holidayDefinition == null)
                throw new ArgumentNullException(nameof(holidayDefinition));
            
            if (string.IsNullOrWhiteSpace(languageTag))
            {
                // set language alias  = default lang from holiday definition
                languageTag = "en"; //todo  temp
            }

            var template = BuildInResourceGetter.Template(holidayDefinition.Country, languageTag);

            if (template == null)
            {
                text = default;
                return false;
            }

            var code = holidayDefinition.I18NIdentityCode.Remove($"i18n_holiday_{template.Alias}_");

            if (template.TryGetText(code, out text))
            {
                return true;
            }

            var gkey = holidayDefinition.GlobalizationKey;

            if (template.TryGetTextByGKey(gkey, out text))
            {
                return true;
            }

            text = default;
            return false;
        }
    }
}