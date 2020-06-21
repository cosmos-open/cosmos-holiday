using System.Collections.Generic;

namespace Cosmos.Business.Extensions.Holiday.Globalization
{
    /// <summary>
    /// Translation resource map
    /// </summary>
    public class TranslationResourceMap
    {
        /*
         * 根据日期查询
         *     01-01            公历 01-01
         *     chinese-01-01    农历 01-01
         *     muslim-01-01     伊斯兰 01-01
         *     easter -48       基督教 -48
         *
         * 根据名称查询
         *     labour            劳动节（对应的日期查询，可以是 05-01）
         *
         * 查询的结果是一组带有 LanguageTag 标记的 PureTranslationText
         */

        private readonly Dictionary<string, TranslationResource> _holidayResourceMap;
        private readonly object _mapLockObj = new object();

        /// <summary>
        /// Create a new instance of <see cref="TranslationResourceMap"/>
        /// </summary>
        public TranslationResourceMap()
        {
            _holidayResourceMap = new Dictionary<string, TranslationResource>();
        }


        #region Add

        /// <summary>
        /// Add
        /// </summary>
        /// <param name="key"></param>
        /// <param name="resource"></param>
        public void Add(string key, TranslationResource resource)
        {
            if (string.IsNullOrWhiteSpace(key))
                return;

            if (resource == null)
                return;

            lock (_mapLockObj)
            {
                if (_holidayResourceMap.ContainsKey(key))
                {
                    _holidayResourceMap[key].Merge(resource);
                }
                else
                {
                    _holidayResourceMap.Add(key, resource);
                }
            }
        }

        /// <summary>
        /// Add
        /// </summary>
        /// <param name="key"></param>
        /// <param name="resource"></param>
        /// <param name="type"></param>
        public void Add(string key, Dictionary<string, string> resource, ResourceType type)
        {
            if (string.IsNullOrWhiteSpace(key))
                return;

            if (resource == null)
                return;

            lock (_mapLockObj)
            {
                if (_holidayResourceMap.ContainsKey(key))
                {
                    _holidayResourceMap[key].AddOrUpdate(resource, type);
                }
                else
                {
                    _holidayResourceMap.Add(key, new TranslationResource(resource, type));
                }
            }
        }

        #endregion

        #region Gets

        /// <summary>
        /// Try get
        /// </summary>
        /// <param name="key"></param>
        /// <param name="lang"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public bool TryGet(string key, string lang, out string text)
        {
            text = default;
            if (string.IsNullOrWhiteSpace(key))
                return false;

            lock (_mapLockObj)
            {
                if (!_holidayResourceMap.ContainsKey(key))
                    return false;

                return _holidayResourceMap[key].TryGetResource(lang, out text);
            }
        }

        /// <summary>
        /// Try get
        /// </summary>
        /// <param name="key"></param>
        /// <param name="lang"></param>
        /// <param name="type"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public bool TryGet(string key, string lang, ResourceType type, out string text)
        {
            text = default;
            if (string.IsNullOrWhiteSpace(key))
                return false;

            lock (_mapLockObj)
            {
                if (!_holidayResourceMap.ContainsKey(key))
                    return false;

                return _holidayResourceMap[key].TryGetResource(lang, type, out text);
            }
        }

        #endregion
    }
}