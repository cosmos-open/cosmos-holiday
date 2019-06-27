using System.Collections.Generic;
using System.Linq;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Helpers;
using Cosmos.Business.Extensions.Holiday.Core.Internals;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions
{
    /// <summary>
    /// Base definition register / base holiday provider
    /// </summary>
    public abstract class BaseDefinitionRegister : IHolidayProvider
    {
        /// <summary>
        /// Country or region
        /// </summary>
        public abstract Country Country { get; }

        /// <summary>
        /// Belongs to country.
        /// </summary>
        public abstract Country BelongsToCountry { get; }

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public abstract IEnumerable<string> IncludeRegions();

        /// <summary>
        /// Does this provider include such region?
        /// </summary>
        /// <param name="regionCode"></param>
        /// <returns></returns>
        public virtual bool DoesIncludeRegion(string regionCode)
        {
            var regions = IncludeRegions().ToList();
            if (!regions.Any())
                return true;
            if (string.IsNullOrWhiteSpace(regionCode))
                return false;
            regionCode = CountryHelper.FixRegionCode(Country, regionCode);
            return regions.Any(x => x == regionCode);
        }

        // ReSharper disable once InconsistentNaming
        private static readonly HolidayType[] _allTypes =
        {
            HolidayType.Public,
            HolidayType.Commemoration,
            HolidayType.Tradition,
            HolidayType.Lunar,
            HolidayType.Religion,
            HolidayType.School,
            HolidayType.Bank,
            HolidayType.Propaganda
        };

        /// <summary>
        /// Register all holiday
        /// </summary>
        public void RegisterAll() => Register(_allTypes);

        /// <summary>
        /// Register the special type of holiday
        /// </summary>
        /// <param name="types"></param>
        public void Register(params HolidayType[] types)
        {
            //if types is null, register all definitions.
            if (types == null || types.Length == 0)
                types = _allTypes;

            if (types.Contains(HolidayType.Public))
                RegisterPublicHoliday();

            if (types.Contains(HolidayType.Commemoration))
                RegisterCommemorationHoliday();

            if (types.Contains(HolidayType.Tradition))
                RegisterTraditionHoliday();

            if (types.Contains(HolidayType.Lunar))
                RegisterLunarHoliday();

            if (types.Contains(HolidayType.Religion))
                RegisterReligionHoliday();

            if (types.Contains(HolidayType.School))
                RegisterSchoolHoliday();

            if (types.Contains(HolidayType.Bank))
                RegisterBankHoliday();

            if (types.Contains(HolidayType.Propaganda))
                RegisterPropagandaHoliday();
        }

        private void RegisterPublicHoliday()
        {
            RegisterFixedFuncs(AllFixedHolidayFuncs.Where(f => f.HolidayType == HolidayType.Public));
            RegisterVariableFuncs(AllVariableHolidayFuncs.Where(f => f.HolidayType == HolidayType.Public));
        }

        private void RegisterCommemorationHoliday()
        {
            RegisterFixedFuncs(AllFixedHolidayFuncs.Where(f => f.HolidayType == HolidayType.Commemoration));
            RegisterVariableFuncs(AllVariableHolidayFuncs.Where(f => f.HolidayType == HolidayType.Commemoration));
        }

        private void RegisterTraditionHoliday()
        {
            RegisterFixedFuncs(AllFixedHolidayFuncs.Where(f => f.HolidayType == HolidayType.Tradition));
            RegisterVariableFuncs(AllVariableHolidayFuncs.Where(f => f.HolidayType == HolidayType.Tradition));
        }

        private void RegisterLunarHoliday()
        {
            RegisterFixedFuncs(AllFixedHolidayFuncs.Where(f => f.HolidayType == HolidayType.Lunar));
            RegisterVariableFuncs(AllVariableHolidayFuncs.Where(f => f.HolidayType == HolidayType.Lunar));
        }

        private void RegisterReligionHoliday()
        {
            RegisterFixedFuncs(AllFixedHolidayFuncs.Where(f => f.HolidayType == HolidayType.Religion));
            RegisterVariableFuncs(AllVariableHolidayFuncs.Where(f => f.HolidayType == HolidayType.Religion));
        }

        private void RegisterSchoolHoliday()
        {
            RegisterFixedFuncs(AllFixedHolidayFuncs.Where(f => f.HolidayType == HolidayType.School));
            RegisterVariableFuncs(AllVariableHolidayFuncs.Where(f => f.HolidayType == HolidayType.School));
        }

        private void RegisterBankHoliday()
        {
            RegisterFixedFuncs(AllFixedHolidayFuncs.Where(f => f.HolidayType == HolidayType.Bank));
            RegisterVariableFuncs(AllVariableHolidayFuncs.Where(f => f.HolidayType == HolidayType.Bank));
        }

        private void RegisterPropagandaHoliday()
        {
            RegisterFixedFuncs(AllFixedHolidayFuncs.Where(f => f.HolidayType == HolidayType.Propaganda));
            RegisterVariableFuncs(AllVariableHolidayFuncs.Where(f => f.HolidayType == HolidayType.Propaganda));
        }

        /// <summary>
        /// Gets all fixed holiday funcs
        /// </summary>
        protected abstract List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; }

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected abstract List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; }

        private static void RegisterFixedFuncs(IEnumerable<IFixedHolidayFunc> funcs)
        {
            foreach (var func in funcs)
                InternalSingleInstanceServiceLocator.HolidayManager.Add(func);
        }

        private static void RegisterVariableFuncs(IEnumerable<IVariableHolidayFunc> funcs)
        {
            foreach (var func in funcs)
                InternalSingleInstanceServiceLocator.HolidayManager.Add(func);
        }

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public abstract IEnumerable<string> GetSources();
    }
}