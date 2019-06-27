using System.Collections.Generic;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Core.Trees
{
    internal class EmptyVariableDailyNode : VariableDailyNode
    {
        // ReSharper disable once InconsistentNaming
        // ReSharper disable once CollectionNeverUpdated.Local
        private static readonly List<IVariableHolidayFunc> _variableHolidayFuncs = new List<IVariableHolidayFunc>();
       
        public EmptyVariableDailyNode(Country country) : base(country) { }

        #region GetFuncs

        /// <summary>
        /// Get a readonly collection of <see cref="IVariableHolidayFunc"/>.
        /// </summary>
        /// <returns></returns>
        public new IReadOnlyList<IVariableHolidayFunc> GetFuncs() => _variableHolidayFuncs;

        /// <summary>
        /// Get a readonly collection of <see cref="IVariableHolidayFunc"/>.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public new IReadOnlyList<IVariableHolidayFunc> GetFuncs(CountryCode code) => _variableHolidayFuncs;

        /// <summary>
        /// Get a readonly collection of <see cref="IVariableHolidayFunc"/>.
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public new IReadOnlyList<IVariableHolidayFunc> GetFuncs(Country country) => _variableHolidayFuncs;

        /// <summary>
        /// Get a readonly collection of <see cref="IVariableHolidayFunc"/>.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <returns></returns>
        public new IReadOnlyList<IVariableHolidayFunc> GetFuncs(CountryCode code, string regionCode) => _variableHolidayFuncs;

        /// <summary>
        /// Get a readonly collection of <see cref="IVariableHolidayFunc"/>.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <returns></returns>
        public new IReadOnlyList<IVariableHolidayFunc> GetFuncs(Country country, string regionCode) => _variableHolidayFuncs;

        /// <summary>
        /// Get a readonly collection of <see cref="IVariableHolidayFunc"/>.
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public new IReadOnlyList<IVariableHolidayFunc> GetFuncs(int year) => _variableHolidayFuncs;

        /// <summary>
        /// Get a readonly collection of <see cref="IVariableHolidayFunc"/>.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public new IReadOnlyList<IVariableHolidayFunc> GetFuncs(CountryCode code, int year) => _variableHolidayFuncs;

        /// <summary>
        /// Get a readonly collection of <see cref="IVariableHolidayFunc"/>.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public new IReadOnlyList<IVariableHolidayFunc> GetFuncs(Country country, int year) => _variableHolidayFuncs;

        /// <summary>
        /// Get a readonly collection of <see cref="IVariableHolidayFunc"/>.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public new IReadOnlyList<IVariableHolidayFunc> GetFuncs(CountryCode code, string regionCode, int year) => _variableHolidayFuncs;

        /// <summary>
        /// Get a readonly collection of <see cref="IVariableHolidayFunc"/>.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public new IReadOnlyList<IVariableHolidayFunc> GetFuncs(Country country, string regionCode, int year) => _variableHolidayFuncs;

        #endregion

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public static EmptyVariableDailyNode Create(Country country) => new EmptyVariableDailyNode(country);

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public static EmptyVariableDailyNode Create(CountryCode code) => new EmptyVariableDailyNode(code.ToCountry());
    }
}