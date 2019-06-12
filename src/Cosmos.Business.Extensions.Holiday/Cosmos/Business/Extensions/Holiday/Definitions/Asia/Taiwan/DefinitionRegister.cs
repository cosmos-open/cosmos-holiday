using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;

/*
 * Taiwan, a part of China
 * 台湾，中华人民共和国的一部分
 */

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Taiwan
{
    using Public;
    using Tradition;

    public class DefinitionRegister : BaseDefinitionRegister
    {
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = CnTwFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> CnTwFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new TombSweepingDay(), //4-5
            new NationalDay(), //10-1
            new MinGuoNationalDay(), //10-10
        };

        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = CnTwVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> CnTwVariableHolidayFuncs = new List<IVariableHolidayFunc>
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