using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Core.Trees
{
    /// <summary>
    /// Variable daily node
    /// </summary>
    public class VariableDailyNode
    {
        private readonly List<IVariableHolidayFunc> _variableHolidayFuncs;

        /// <summary>
        /// Create a new instance of <see cref="VariableDailyNode"/>
        /// </summary>
        /// <param name="country"></param>
        public VariableDailyNode(Country country)
        {
            Country = country;
            _variableHolidayFuncs = new List<IVariableHolidayFunc>();
        }

        /// <summary>
        /// Country
        /// </summary>
        public Country Country { get; }

        #region GetFuncs

        /// <summary>
        /// Get a readonly collection of <see cref="IVariableHolidayFunc"/>.
        /// </summary>
        /// <returns></returns>
        public IReadOnlyList<IVariableHolidayFunc> GetFuncs()
        {
            return _variableHolidayFuncs.AsReadOnly();
        }

        /// <summary>
        /// Get a readonly collection of <see cref="IVariableHolidayFunc"/>.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public IReadOnlyList<IVariableHolidayFunc> GetFuncs(CountryCode code)
        {
            return GetFuncs(code.ToCountry());
        }

        /// <summary>
        /// Get a readonly collection of <see cref="IVariableHolidayFunc"/>.
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public IReadOnlyList<IVariableHolidayFunc> GetFuncs(Country country)
        {
            return _variableHolidayFuncs
                .Where(f => f.BelongsToCountry == country)
                .ToList()
                .AsReadOnly();
        }
        
        /// <summary>
        /// Get a readonly collection of <see cref="IVariableHolidayFunc"/>.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <returns></returns>
        public IReadOnlyList<IVariableHolidayFunc> GetFuncs(CountryCode code, string regionCode)
        {
            return GetFuncs(code.ToCountry(), regionCode);
        }

        /// <summary>
        /// Get a readonly collection of <see cref="IVariableHolidayFunc"/>.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <returns></returns>
        public IReadOnlyList<IVariableHolidayFunc> GetFuncs(Country country, string regionCode)
        {
            return _variableHolidayFuncs
                .Where(f => f.BelongsToCountry == country && f.MatchRegion(regionCode))
                .ToList()
                .AsReadOnly();
        }

        /// <summary>
        /// Get a readonly collection of <see cref="IVariableHolidayFunc"/>.
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public IReadOnlyList<IVariableHolidayFunc> GetFuncs(int year)
        {
            return _variableHolidayFuncs
                .Where(f => (f.Since == null || f.Since <= year) && (f.End == null || f.End >= year))
                .ToList()
                .AsReadOnly();
        }
        
        /// <summary>
        /// Get a readonly collection of <see cref="IVariableHolidayFunc"/>.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public IReadOnlyList<IVariableHolidayFunc> GetFuncs(CountryCode code, int year)
        {
            return GetFuncs(code.ToCountry(), year);
        }

        /// <summary>
        /// Get a readonly collection of <see cref="IVariableHolidayFunc"/>.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public IReadOnlyList<IVariableHolidayFunc> GetFuncs(Country country, int year)
        {
            return _variableHolidayFuncs
                .Where(f => f.BelongsToCountry == country)
                .Where(f => (f.Since == null || f.Since <= year) && (f.End == null || f.End >= year))
                .ToList()
                .AsReadOnly();
        }

        /// <summary>
        /// Get a readonly collection of <see cref="IVariableHolidayFunc"/>.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public IReadOnlyList<IVariableHolidayFunc> GetFuncs(CountryCode code, string regionCode, int year)
        {
            return GetFuncs(code.ToCountry(), regionCode, year);
        }

        /// <summary>
        /// Get a readonly collection of <see cref="IVariableHolidayFunc"/>.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public IReadOnlyList<IVariableHolidayFunc> GetFuncs(Country country, string regionCode, int year)
        {
            return _variableHolidayFuncs
                .Where(f => f.BelongsToCountry == country && f.MatchRegion(regionCode))
                .Where(f => (f.Since == null || f.Since <= year) && (f.End == null || f.End >= year))
                .ToList()
                .AsReadOnly();
        }
        
        #endregion

        #region Add

        /// <summary>
        /// Add
        /// </summary>
        /// <param name="func"></param>
        public void Add(IVariableHolidayFunc func)
        {
            if (func == null)
                return;

            if (func.BelongsToCountry != Country)
                return;

            if (Contains(func))
                return;

            _variableHolidayFuncs.Add(func);
        }

        #endregion

        #region Contains

        /// <summary>
        /// Contains<br />
        /// 包含
        /// </summary>
        /// <param name="func">An instance of <see cref="IVariableHolidayFunc"/>.</param>
        /// <returns></returns>
        public bool Contains(IVariableHolidayFunc func)
        {
            if (func == null)
                return false;

            if (_variableHolidayFuncs.Any(x => x.I18NIdentityCode == func.I18NIdentityCode))
                return true;

            if (_variableHolidayFuncs.Any(x => x.Name == func.Name && x.BelongsToCountry == func.BelongsToCountry))
                return true;

            return false;
        }

        #endregion

    }
}