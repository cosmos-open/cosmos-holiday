using System.Collections.Generic;

namespace Cosmos.Business.Extensions.Holiday.Globalization.Strategy
{
    /// <summary>
    /// Language context
    /// </summary>
    public class LanguageContext
    {
        /// <summary>
        /// Language tag
        /// </summary>
        public string LanguageAlias { get; set; }

        /// <summary>
        /// A list of language tag
        /// </summary>
        public List<string> LanguageSequence { get; set; }
    }
}