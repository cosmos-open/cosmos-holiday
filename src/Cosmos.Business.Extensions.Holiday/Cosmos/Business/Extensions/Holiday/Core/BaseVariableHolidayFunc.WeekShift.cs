using System;
using Cosmos.Business.Extensions.Holiday.Core.Extensions;
using Cosmos.Date;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Core
{
    /// <summary>
    /// Shift variable holiday func
    /// </summary>
    public abstract class WeekShiftVariableHolidayFunc : BaseVariableHolidayFunc
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

        #region Shift additional

        /// <summary>
        /// Monday shift days
        /// </summary>
        protected virtual int MondayShift { get; } = 0;

        /// <summary>
        /// Tuesday shift days
        /// </summary>
        protected virtual int TuesdayShift { get; } = 0;

        /// <summary>
        /// Wednesday shift days
        /// </summary>
        protected virtual int WednesdayShift { get; } = 0;
        
        /// <summary>
        /// Thursday shift days
        /// </summary>
        protected virtual int ThursdayShift { get; } = 0;
        
        /// <summary>
        /// Friday shift days
        /// </summary>
        protected virtual int FridayShift { get; } = 0;

        #endregion

        /// <inheritdoc />
        public override DailyAnswer ToDailyAnswer(int year)
        {
            var saturdayFunc = SaturdayShift == 0 ? Self() : Shift(SaturdayShift);
            var sundayFunc = SundayShift == 0 ? Self() : Shift(SundayShift);

            var calculationDay = DateTimeFactory
                .Create(year, Month, Day)
                .Shift(saturdayFunc, sundayFunc);

            if (MondayShift != 0)
                calculationDay = calculationDay.MondayShift(Shift(MondayShift));

            if (TuesdayShift != 0)
                calculationDay = calculationDay.TuesdayShift(Shift(TuesdayShift));

            if (WednesdayShift != 0)
                calculationDay = calculationDay.WednesdayShift(Shift(WednesdayShift));
            
            if (ThursdayShift != 0)
                calculationDay = calculationDay.ThursdayShift(Shift(ThursdayShift));
            
            if (FridayShift != 0)
                calculationDay = calculationDay.FridayShift(Shift(FridayShift));

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