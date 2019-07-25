using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Venezuela.Commemoration
{
    /// <summary>
    /// St Joseph's Day
    /// </summary>
    public class StJosephsDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Venezuela;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Venezuela;

        /// <inheritdoc />
        public override string Name { get; } = "Día de San José";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 3;

        /// <inheritdoc />
        public override int Day { get; set; } = 19;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ve_joseph";
    }
}