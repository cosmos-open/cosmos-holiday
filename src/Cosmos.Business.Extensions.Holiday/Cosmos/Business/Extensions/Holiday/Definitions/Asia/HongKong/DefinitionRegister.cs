using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;

/*
 * Hong Kong, a part of China
 * 香港，中华人民共和国的一部分
 */

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.HongKong
{
    using Public;
    using Tradition;

    public class DefinitionRegister : BaseDefinitionRegister
    {
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = CnHkFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> CnHkFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new NationalDay(), //10-1
            new Christmas(),//12-25
        };

        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = CnHkVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> CnHkVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new ChineseNewYearsEve(), //农历（上一年）12-30
            new ChineseNewYear(), //农历1-1
            new LanternFestival(), //农历1-15
            new TombSweepingDay(), //4-5
            new DragonBoatFestival(), //农历5-5
            new MidAutumnFestival(), //农历8-15
            new DoubleNinthFestival(), //农历9-9
            new LabaFestival(), //农历12-8
        };

        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_China",
            };
        }
    }
}