using System;
using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;

namespace Cosmos.Business.Extensions.Holiday.Configuration
{
    /// <summary>
    /// Holiday options
    /// </summary>
    /// <typeparam name="TOptions"></typeparam>
    public abstract class HolidayOptions<TOptions> where TOptions : HolidayOptions<TOptions>
    {
        /// <summary>
        /// Runtime fixed holiday funcs
        /// </summary>
        // ReSharper disable once InconsistentNaming
        // ReSharper disable once CollectionNeverUpdated.Global
        protected List<RuntimeFixedHolidayFunc> _RuntimeFixedHolidayFuncs { get; set; }

        /// <summary>
        /// Holiday options
        /// </summary>
        protected HolidayOptions()
        {
            _RuntimeFixedHolidayFuncs = new List<RuntimeFixedHolidayFunc>();
        }

        /// <summary>
        /// Use provider for special holiday
        /// </summary>
        /// <param name="holidayTypes"></param>
        /// <typeparam name="TProvider"></typeparam>
        /// <returns></returns>
        public TOptions Use<TProvider>(params HolidayType[] holidayTypes) where TProvider : class, IHolidayProvider, new()
        {
            HolidayProviderManager.Register<TProvider>(holidayTypes);
            return this as TOptions;
        }

        /// <summary>
        /// Use provider for special holiday
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="holidayTypes"></param>
        /// <typeparam name="TProvider"></typeparam>
        /// <returns></returns>
        public TOptions Use<TProvider>(TProvider provider, params HolidayType[] holidayTypes) where TProvider : class, IHolidayProvider, new()
        {
            HolidayProviderManager.Register(provider ?? throw new ArgumentNullException(nameof(provider)), holidayTypes);
            return this as TOptions;
        }


        #region Weekend

        /// <summary>
        /// Weekend Unlinked Assemblies Pattern
        /// </summary>
        protected string _WeekendUnlinkedAssembliesPattern { get; set; }

        /// <summary>
        /// Weekend Include Extend Definitions
        /// </summary>
        protected bool _WeekendIncludeExtendDefinitions { get; set; }

        /// <summary>
        /// Sets Weekend Unlinked Assemblies Pattern
        /// </summary>
        /// <param name="pattern"></param>
        /// <returns></returns>
        public TOptions SetWeekendUnlinkedAssembliesPattern(string pattern)
        {
            _WeekendUnlinkedAssembliesPattern = pattern;
            return this as TOptions;
        }

        /// <summary>
        /// Set Weekend Include Extend Definitions
        /// </summary>
        /// <returns></returns>
        public TOptions SetWeekIncludeExtendDefinitions()
        {
            _WeekendIncludeExtendDefinitions = true;
            return this as TOptions;
        }

        /// <summary>
        /// Biz weekend definitions
        /// </summary>
        // ReSharper disable once InconsistentNaming
        // ReSharper disable once CollectionNeverQueried.Global
        protected List<IBizWeekendDefinition> _bizWeekendDefinitions { get; } = new List<IBizWeekendDefinition>();

        /// <summary>
        /// Use weekend definitions
        /// </summary>
        /// <typeparam name="TWeekendDefinition"></typeparam>
        /// <returns></returns>
        public TOptions Use<TWeekendDefinition>() where TWeekendDefinition : class, IBizWeekendDefinition, new()
        {
            return Use(new TWeekendDefinition());
        }

        /// <summary>
        /// Use weekend definitions
        /// </summary>
        /// <param name="definition"></param>
        /// <typeparam name="TWeekendDefinition"></typeparam>
        /// <returns></returns>
        public TOptions Use<TWeekendDefinition>(TWeekendDefinition definition) where TWeekendDefinition : class, IBizWeekendDefinition, new()
        {
            if (definition != null)
                _bizWeekendDefinitions.Add(definition);
            return this as TOptions;
        }

        /// <summary>
        /// Use weekend definitions
        /// </summary>
        /// <param name="definitions"></param>
        /// <returns></returns>
        public TOptions Use(IEnumerable<IBizWeekendDefinition> definitions)
        {
            if (definitions != null)
            {
                foreach (var definition in definitions)
                    if (definition != null)
                        _bizWeekendDefinitions.Add(definition);
            }

            return this as TOptions;
        }

        #endregion

    }
}