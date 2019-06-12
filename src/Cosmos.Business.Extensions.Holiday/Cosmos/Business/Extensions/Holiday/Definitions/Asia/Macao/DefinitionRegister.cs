using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;

/*
 * Macao, a part of China
 * 澳门，中华人民共和国的一部分
 */

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Macao
{
    using Public;
    using Tradition;

    public class DefinitionRegister : BaseDefinitionRegister
    {
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = CnMoFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> CnMoFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new TombSweepingDay(), //4-5
            new NationalDay(), //10-1
        };

        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = CnMoVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> CnMoVariableHolidayFuncs = new List<IVariableHolidayFunc>
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