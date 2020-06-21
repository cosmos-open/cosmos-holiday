using Cosmos.Business.Extensions.Holiday.Core.Helpers;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Core
{
    /// <summary>
    /// Chinese variable holiday func
    /// </summary>
    public abstract class ChineseVariableHolidayFunc : BaseVariableHolidayFunc
    {

        #region Chinese Date

        /// <summary>
        /// 农历月份
        /// </summary>
        protected abstract int ChineseMonth { get; }

        /// <summary>
        /// 农历日份
        /// </summary>
        protected abstract int ChineseDay { get; }

        #endregion

        #region Globalization Key

        /// <inheritdoc />
        public override string GlobalizationKey => $"chinese {MayZero(ChineseMonth)}-{MayZero(ChineseDay)}";

        private static string MayZero(int value) => (100 + value).ToString().Right(2);

        #endregion

        #region To daily answer

        /// <summary>
        /// Convert to <see cref="DailyAnswer"/>
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public override DailyAnswer ToDailyAnswer(int year)
        {
            var calendar = ChineseLunisolarCalendarHelper.Instance;
            var leapMonth = calendar.GetLeapMonthAndCache(year);
            var date = calendar.ToDateTime(year, ChineseLunisolarCalendarHelper.MoveMonth(ChineseMonth, leapMonth), ChineseDay);

            var builder = DailyAnswerBuilder.Create(Name, HolidayType).From(date);

            if (Since.HasValue)
                builder.Since(Since.Value);

            if (End.HasValue)
                builder.End(End.Value);

            if (TimeStepValue.HasValue)
                builder.Times(TimeStepValue.Value);

            builder.Country(Country.ToCode(), GetRegionCodeList());

            return builder.I18N(I18NIdentityCode).Build(year);
        }

        #endregion

    }
}