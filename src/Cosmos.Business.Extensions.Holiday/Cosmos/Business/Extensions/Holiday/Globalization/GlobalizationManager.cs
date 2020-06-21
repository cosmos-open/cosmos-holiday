using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Globalization.Internals;
using EnumsNET;

namespace Cosmos.Business.Extensions.Holiday.Globalization
{
    /// <summary>
    /// Default business holiday globalization manager
    /// </summary>
    public class GlobalizationManager : IBizHolidayGlobalizationManager
    {
        private readonly TranslationResourceMap _coreMap;

        /// <summary>
        /// Create a new default instance of <see cref="GlobalizationManager"/>
        /// </summary>
        public GlobalizationManager()
        {
            _coreMap = new TranslationResourceMap();

            InitEmbeddedResource(ResourceType.All);
        }

        /// <summary>
        /// Create a new default instance of <see cref="GlobalizationManager"/>
        /// </summary>
        /// <param name="type"></param>
        public GlobalizationManager(ResourceType type)
        {
            _coreMap = new TranslationResourceMap();

            InitEmbeddedResource(type);
        }

        private void InitEmbeddedResource(ResourceType type)
        {
            foreach (var template in EmbeddedResourceGetter.All)
            {
                var currentType = ResourceTypeSwitcher.Switch(template.Type);

                if (currentType == ResourceType.All)
                    continue;

                if (!type.HasAnyFlags(currentType))
                    continue;

                foreach (var kwp in template.Data)
                {
                    //kwp: key = date or name or other... w(wrapper) = lang-text-pair
                    _coreMap.Add(kwp.Key, kwp.Value, currentType);
                }
            }
        }

        #region Gets

        /// <summary>
        /// Get text
        /// </summary>
        /// <param name="key"></param>
        /// <param name="lang"></param>
        /// <returns></returns>
        public string GetText(string key, string lang)
        {
            return TryGetText(key, lang, out var text) ? text : default;
        }

        /// <summary>
        /// Get text
        /// </summary>
        /// <param name="key"></param>
        /// <param name="lang"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public string GetText(string key, string lang, ResourceType type)
        {
            return TryGetText(key, lang, type, out var text) ? text : default;
        }

        /// <summary>
        /// Try get text
        /// </summary>
        /// <param name="key"></param>
        /// <param name="lang"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public bool TryGetText(string key, string lang, out string text)
        {
            return _coreMap.TryGet(key, lang, out text);
        }

        /// <summary>
        /// Try get text
        /// </summary>
        /// <param name="key"></param>
        /// <param name="lang"></param>
        /// <param name="type"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public bool TryGetText(string key, string lang, ResourceType type, out string text)
        {
            return _coreMap.TryGet(key, lang, type, out text);
        }

        #endregion

    }
}