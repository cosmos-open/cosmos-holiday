using System;
using System.Collections.Generic;

namespace Cosmos.Business.Extensions.Holiday.Globalization
{
    /// <summary>
    /// Translation resource
    /// </summary>
    public class TranslationResource
    {
        /// <summary>
        /// Text list, key = lang, value = holiday's name
        /// </summary>
        private readonly Dictionary<string, PureTranslationText> _pureTranslationTexts;

        /// <summary>
        /// Create a new instance of <see cref="TranslationResource"/>
        /// </summary>
        public TranslationResource()
        {
            _pureTranslationTexts = new Dictionary<string, PureTranslationText>();
        }

        /// <summary>
        /// Create a new instance of <see cref="TranslationResource"/>
        /// </summary>
        /// <param name="resource"></param>
        /// <param name="type"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public TranslationResource(Dictionary<string, string> resource, ResourceType type)
        {
            if (resource == null)
                throw new ArgumentNullException(nameof(resource));

            _pureTranslationTexts = new Dictionary<string, PureTranslationText>();

            Add(resource, type);
        }

        /// <summary>
        /// Create a new instance of <see cref="TranslationResource"/>
        /// </summary>
        /// <param name="resource"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public TranslationResource(TranslationResource resource)
        {
            if (resource == null)
                throw new ArgumentNullException(nameof(resource));

            _pureTranslationTexts = new Dictionary<string, PureTranslationText>();

            Merge(resource);
        }

        #region Add

        /// <summary>
        /// Add
        /// </summary>
        /// <param name="lang"></param>
        /// <param name="text"></param>
        /// <param name="type"></param>
        public void Add(string lang, string text, ResourceType type)
        {
            if (string.IsNullOrWhiteSpace(lang))
                return;

            if (_pureTranslationTexts.ContainsKey(lang))
                return;

            _pureTranslationTexts.Add(lang, new PureTranslationText(lang, text, type));
        }

        /// <summary>
        /// Add
        /// </summary>
        /// <param name="langTextPair"></param>
        public void Add(Dictionary<string, string> langTextPair, ResourceType type)
        {
            if (langTextPair == null)
                return;

            foreach (var ltp in langTextPair)
            {
                Add(ltp.Key, ltp.Value, type);
            }
        }

        /// <summary>
        /// Add or update
        /// </summary>
        /// <param name="lang"></param>
        /// <param name="text"></param>
        public void AddOrUpdate(string lang, string text, ResourceType type)
        {
            if (string.IsNullOrWhiteSpace(lang))
                return;

            if (_pureTranslationTexts.ContainsKey(lang))
                _pureTranslationTexts[lang] = new PureTranslationText(lang, text, type);
            else
                _pureTranslationTexts.Add(lang, new PureTranslationText(lang, text, type));
        }

        /// <summary>
        /// Add or update
        /// </summary>
        /// <param name="langTextPair"></param>
        public void AddOrUpdate(Dictionary<string, string> langTextPair, ResourceType type)
        {
            if (langTextPair == null)
                return;

            foreach (var ltp in langTextPair)
            {
                AddOrUpdate(ltp.Key, ltp.Value, type);
            }
        }

        #endregion

        #region Merge

        /// <summary>
        /// Merge
        /// </summary>
        /// <param name="resource"></param>
        public void Merge(TranslationResource resource)
        {
            if (resource == null)
                return;

            foreach (var textWrapper in resource._pureTranslationTexts)
            {
                var _ = textWrapper.Value;

                if (_ == null)
                    continue;

                AddOrUpdate(_.LanguageAlias, _.Text, _.Type);
            }
        }

        #endregion

        #region Gets

        /// <summary>
        /// Try get resource
        /// </summary>
        /// <param name="lang"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public bool TryGetResource(string lang, out string text)
        {
            text = default;

            if (_pureTranslationTexts.TryGetValue(lang, out var translationText))
            {
                text = translationText.Text;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Try get resource
        /// </summary>
        /// <param name="lang"></param>
        /// <param name="type"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        public bool TryGetResource(string lang, ResourceType type, out string text)
        {
            text = default;

            if (_pureTranslationTexts.TryGetValue(lang, out var translationText) && translationText.IsMatch(lang, type))
            {
                text = translationText.Text;
                return true;
            }

            return false;
        }

        #endregion

    }
}