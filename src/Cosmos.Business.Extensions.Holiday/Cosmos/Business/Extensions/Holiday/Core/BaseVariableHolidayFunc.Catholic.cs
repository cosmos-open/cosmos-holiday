using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Core
{
    /// <summary>
    /// Catholic Variable Holiday Func
    /// </summary>
    public abstract class CatholicVariableHolidayFunc : BaseVariableHolidayFunc
    {

        #region Easter fix

        /// <summary>
        /// Offset Easter Sunday
        /// </summary>
        protected virtual int OffsetEasterSunday { get; } = 0;

        #endregion

        /// <inheritdoc />
        public override DailyAnswer ToDailyAnswer(int year)
        {
            var calculationDay = OffsetEasterSunday == 0
                ? Helpers.CatholicHelper.EasterSunday(year)
                : Helpers.CatholicHelper.EasterSunday(year).AddDays(OffsetEasterSunday);

            var builder = DailyAnswerBuilder
                .Create(Name, HolidayType)
                .From(calculationDay);

            if (Since.HasValue)
                builder.Since(Since.Value);

            if (End.HasValue)
                builder.End(End.Value);

            if (TimeStepValue.HasValue)
                builder.Times(TimeStepValue.Value);

            builder.Country(Country.ToCode(), GetRegionCodeList());

            return builder.I18N(I18NIdentityCode).Build(year);
        }

    }
}