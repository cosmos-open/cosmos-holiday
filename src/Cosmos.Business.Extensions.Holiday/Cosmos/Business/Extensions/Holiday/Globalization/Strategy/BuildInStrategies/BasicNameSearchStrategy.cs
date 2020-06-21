using System;
using Cosmos.Business.Extensions.Holiday.Core;

namespace Cosmos.Business.Extensions.Holiday.Globalization.Strategy.BuildInStrategies
{
    /// <summary>
    /// Basic holiday name strategy
    /// </summary>
    public class BasicNameSearchStrategy : ISearchStrategy
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
            else
            {
                //todo 检查是否为默认 language
                //如果不是，则返回 False
            }

            if (string.IsNullOrWhiteSpace(holidayDefinition.Name))
            {
                text = default;
                return false;
            }

            text = holidayDefinition.Name;
            return true;
        }
    }
}