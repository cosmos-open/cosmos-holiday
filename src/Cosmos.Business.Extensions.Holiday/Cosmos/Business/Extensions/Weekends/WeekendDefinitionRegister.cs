using System.Collections.Generic;
using Cosmos.Abstractions;

namespace Cosmos.Business.Extensions.Weekends
{
    public class WeekendDefinitionRegister
    {
        private WeekendDefinitionRegister() { }

        public static WeekendDefinitionRegister Create() => new WeekendDefinitionRegister();

        #region Scanner

        private IEnumerable<IBizWeekendDefinition> WeekendDefinitions { get; set; }
        private bool _includeExtendDefinitions;
        private string _unlinkedAssembliesPattern;

        public WeekendDefinitionRegister IncludeExtendDefinitions()
        {
            _includeExtendDefinitions = true;
            return this;
        }

        public WeekendDefinitionRegister UnlinkedAssembliesPattern(string pattern)
        {
            _unlinkedAssembliesPattern = pattern;
            return this;
        }

        public WeekendDefinitionRegister Scan()
        {
            var scanner = new WeekendDefinitionScanner(_includeExtendDefinitions, _unlinkedAssembliesPattern);
            WeekendDefinitions = scanner.Scan();
            return this;
        }

        #endregion

        #region Register

        private List<IBizWeekendDefinition> CustomDefinitions { get; set; } = new List<IBizWeekendDefinition>();

        public WeekendDefinitionRegister Register(IBizWeekendDefinition definition)
        {
            if (definition != null)
                CustomDefinitions.Add(definition);
            return this;
        }

        public WeekendDefinitionRegister Register(IEnumerable<IBizWeekendDefinition> definitions)
        {
            if (definitions != null)
                CustomDefinitions.AddRange(definitions);
            return this;
        }

        #endregion

        #region Done

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