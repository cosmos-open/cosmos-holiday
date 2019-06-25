using System.Collections.Generic;
using Cosmos.Abstractions;

namespace Cosmos.Business.Extensions.Weekends
{
    /// <summary>
    /// Weekend definition register
    /// </summary>
    public class WeekendDefinitionRegister
    {
        private WeekendDefinitionRegister() { }

        /// <summary>
        /// Create
        /// </summary>
        /// <returns></returns>
        public static WeekendDefinitionRegister Create() => new WeekendDefinitionRegister();

        #region Scanner

        private IEnumerable<IBizWeekendDefinition> WeekendDefinitions { get; set; }
        private bool _includeExtendDefinitions;
        private string _unlinkedAssembliesPattern;

        /// <summary>
        /// Include extend definitions
        /// </summary>
        /// <returns></returns>
        public WeekendDefinitionRegister IncludeExtendDefinitions()
        {
            _includeExtendDefinitions = true;
            return this;
        }

        /// <summary>
        /// UnlinkedAssembliesPattern
        /// </summary>
        /// <param name="pattern"></param>
        /// <returns></returns>
        public WeekendDefinitionRegister UnlinkedAssembliesPattern(string pattern)
        {
            _unlinkedAssembliesPattern = pattern;
            return this;
        }

        /// <summary>
        /// Scan
        /// </summary>
        /// <returns></returns>
        public WeekendDefinitionRegister Scan()
        {
            var scanner = new WeekendDefinitionScanner(_includeExtendDefinitions, _unlinkedAssembliesPattern);
            WeekendDefinitions = scanner.Scan();
            return this;
        }

        #endregion

        #region Register

        private List<IBizWeekendDefinition> CustomDefinitions { get; set; } = new List<IBizWeekendDefinition>();

        /// <summary>
        /// Register
        /// </summary>
        /// <param name="definition"></param>
        /// <returns></returns>
        public WeekendDefinitionRegister Register(IBizWeekendDefinition definition)
        {
            if (definition != null)
                CustomDefinitions.Add(definition);
            return this;
        }

        /// <summary>
        /// Register
        /// </summary>
        /// <param name="definitions"></param>
        /// <returns></returns>
        public WeekendDefinitionRegister Register(IEnumerable<IBizWeekendDefinition> definitions)
        {
            if (definitions != null)
                CustomDefinitions.AddRange(definitions);
            return this;
        }

        #endregion

        #region Done

        /// <summary>
        /// Done
        /// </summary>
        public void Done()
        {
            if (WeekendDefinitions != null)
            {
                foreach (var definition in WeekendDefinitions)
                {
                    WeekendManager.Register(definition);
                }
            }

            if (CustomDefinitions != null)
            {
                foreach (var definition in CustomDefinitions)
                {
                    WeekendManager.Register(definition);
                }
            }
        }

        #endregion

    }
}