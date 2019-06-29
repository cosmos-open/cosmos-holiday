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
        protected abstract int SaturdayShift { get; }

        /// <summary>
        /// Sunday shift days
        /// </summary>
        protected abstract int SundayShift { get; }

        #endregion

        /// <inheritdoc />
        public override DailyAnswer ToDailyAnswer(int year)
        {
            var calculationDay = DateTimeFactory
                .Create(year, Month, Day)
                .Shift(saturday => saturday.AddDays(SaturdayShift), sunday => sunday.AddDays(SundayShift));

            return DailyAnswerBuilder
                .Create(Name)
                .From(calculationDay)
                .Country(Country.ToCode(), GetRegionCodeList())
                .I18N(I18NIdentityCode)
                .Build(year);
        }
    }
}