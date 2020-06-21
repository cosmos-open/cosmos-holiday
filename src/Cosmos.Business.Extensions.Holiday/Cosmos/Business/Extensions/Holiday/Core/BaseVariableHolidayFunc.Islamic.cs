using Cosmos.Business.Extensions.Holiday.Core.Globalization;
using Cosmos.Business.Extensions.Holiday.Core.Helpers;
using Cosmos.I18N.Countries;
using Humanizer;

namespace Cosmos.Business.Extensions.Holiday.Core
{
    /// <summary>
    /// Islamic/Hijri variable holiday func
    /// </summary>
    public abstract class IslamicVariableHolidayFunc : BaseVariableHolidayFunc
    {

        #region Muslim Date

        /// <summary>
        /// 穆斯林月份
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        protected virtual IslamicMonths IslamicMonth { get; set; }

        /// <summary>
        /// 穆斯林日份
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        protected virtual int IslamicDay { get; set; }

        /// <summary>
        /// 从穆斯林日期
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        protected virtual (IslamicMonths Month, int Day)? FromIslamicDate { get; set; }

        /// <summary>
        /// 到穆斯林日期
        /// </summary>
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        protected virtual (IslamicMonths Month, int Day)? ToIslamicDate { get; set; }

        #endregion

        #region Globalization Key

        /// <inheritdoc />
        public override string GlobalizationKey
            => FromIslamicDate.HasValue
                ? $"{FromIslamicDate.Value.Day} {FromIslamicDate.Value.Month.Humanize()}"
                : $"{IslamicDay} {IslamicMonth.Humanize()}";

        #endregion

        #region To daily answer

        /// <summary>
        /// Convert to <see cref="DailyAnswer"/>
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public override DailyAnswer ToDailyAnswer(int year)
        {
            var calendar = HijriCalendarHelper.Instance;
            var builder = DailyAnswerBuilder.Create(Name, HolidayType);

            if (!FromIslamicDate.HasValue && !ToIslamicDate.HasValue)
            {
                var date = calendar.ToDateTime(year, IslamicMonth, IslamicDay);
                builder.From(date);
            }
            else if (FromIslamicDate.HasValue && !ToIslamicDate.HasValue)
            {
                var date = calendar.ToDateTime(year, FromIslamicDate.Value);
                builder.From(date);
            }
            else if (FromIslamicDate.HasValue)
            {
                var date1 = calendar.ToDateTime(year, FromIslamicDate.Value);
                var date2 = calendar.ToDateTime(year, ToIslamicDate.Value);
                builder.From(date1).To(date2);
            }

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