using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.China
{
    using Public;
    using Tradition;

    public class DefinitionRegister : BaseDefinitionRegister
    {
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = CnFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> CnFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new TombSweepingDay(), //4-5
            new MayDay(), //5-1
            new NationalDay(), //10-1
        };

        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = CnVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> CnVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new ChineseNewYear(), //农历1-1
            new DragonBoatFestival(), //农历5-5
            new MidAutumnFestival(), //农历8-15
        };

        public override IEnumerable<string> GetSources()
        {
            return new string[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_China",
            };
        }
    }
}