using System.Collections.Generic;
using System.Linq;
using Cosmos.Business.Extensions.Holiday.Core;

namespace Cosmos.Business.Extensions.Holiday.Definitions
{
    public abstract class BaseDefinitionRegister
    {
        private static readonly HolidayType[] _allTypes = new[]
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

        public void RegisterAll() => Register(_allTypes);

        public void Register(params HolidayType[] types)
        {
            //if types is null, register all definitions.
            types = types ?? _allTypes;

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
        }

        private void RegisterCommemorationHoliday()
        {
            RegisterFixedFuncs(AllFixedHolidayFuncs.Where(f => f.HolidayType == HolidayType.Commemoration));
        }

        private void RegisterTraditionHoliday()
        {
            RegisterFixedFuncs(AllFixedHolidayFuncs.Where(f => f.HolidayType == HolidayType.Tradition));
        }

        private void RegisterLunarHoliday()
        {
            RegisterFixedFuncs(AllFixedHolidayFuncs.Where(f => f.HolidayType == HolidayType.Lunar));
        }

        private void RegisterReligionHoliday()
        {
            RegisterFixedFuncs(AllFixedHolidayFuncs.Where(f => f.HolidayType == HolidayType.Religion));
        }

        private void RegisterSchoolHoliday()
        {
            RegisterFixedFuncs(AllFixedHolidayFuncs.Where(f => f.HolidayType == HolidayType.School));
        }

        private void RegisterBankHoliday()
        {
            RegisterFixedFuncs(AllFixedHolidayFuncs.Where(f => f.HolidayType == HolidayType.Bank));
        }

        private void RegisterPropagandaHoliday()
        {
            RegisterFixedFuncs(AllFixedHolidayFuncs.Where(f => f.HolidayType == HolidayType.Propaganda));
        }

        protected abstract List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; }

        protected abstract List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; }

        private static void RegisterFixedFuncs(IEnumerable<IFixedHolidayFunc> funcs)
        {
            foreach (var func in funcs)
                HolidayManager.Add(func);
        }

        public abstract IEnumerable<string> GetSources();
    }
}