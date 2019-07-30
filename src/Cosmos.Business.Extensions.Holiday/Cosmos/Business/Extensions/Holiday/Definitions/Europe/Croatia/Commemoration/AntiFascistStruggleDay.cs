using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Croatia.Commemoration
{
    /// <summary>
    /// Anti-Fascist Struggle Day
    /// </summary>
    public class AntiFascistStruggleDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Croatia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Croatia;

        /// <inheritdoc />
        public override string Name { get; } = "Dan antifašističke borbe";

        /// <inheritdoc />
        public override int Month { get; set; } = 6;

        /// <inheritdoc />
        public override int Day { get; set; } = 22;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_hr_anti_fascist_stuggle";
    }
}