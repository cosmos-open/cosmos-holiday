using System;
using Cosmos.Business.Extensions.Holiday.Core.Extensions;
using Cosmos.Date;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Core
{
    /// <summary>
    /// Shift variable holiday func
    /// </summary>
    public abstract class ShiftVariableHolidayFunc : BaseVariableHolidayFunc
    {

        #region Date

        /// <summary>
        /// Month
        /// </summary>
        public abstract int Month { get; }

        /// <summary>
        /// Day
        /// </summary>
        public abstract int Day { get; }

        #endregion

        #region Shift

        /// <summary>
        /// Saturday shift days
        /// </summary>
        protected virtual int SaturdayShift { get; } = 0;

        /// <summary>
        /// Sunday shift days
        /// </summary>
        protected virtual int SundayShift { get; } = 0;

        #endregion

        /// <inheritdoc />
        public override DailyAnswer ToDailyAnswer(int year)
        {
            var saturdayFunc = SaturdayShift == 0 ? Self() : Shift(SaturdayShift);
            var sundayFunc = SundayShift == 0 ? Self() : Shift(SundayShift);

            var calculationDay = DateTimeFactory
                .Create(year, Month, Day)
                .Shift(saturdayFunc, sundayFunc);

            var builder = DailyAnswerBuilder.Create(Name, HolidayType).From(calculationDay);

            if (Since.HasValue)
                builder.Since(Since.Value);

            if (End.HasValue)
                builder.End(End.Value);

            if (TimeStepValue.HasValue)
                builder.Times(TimeStepValue.Value);

            builder.Country(Country.ToCode(), GetRegionCodeList());

            return builder.I18N(I18NIdentityCode).Build(year);
        }

        private static Func<DateTime, DateTime> Self() => dt => dt;
        private static Func<DateTime, DateTime> Shift(int days) => dt => dt.AddDays(days);
    }
}