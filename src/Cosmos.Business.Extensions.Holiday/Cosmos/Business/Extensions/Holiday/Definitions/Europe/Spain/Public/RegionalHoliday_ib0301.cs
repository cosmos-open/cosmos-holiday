using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Spain.Public
{
    /// <summary>
    /// Regional Holiday
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public class RegionalHoliday_ib0301: BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Spain;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Spain;

        /// <inheritdoc />
        public override string RegionCode { get; } = "ES-IB";

        /// <inheritdoc />
        public override string Name { get; } = "Dia de les Illes Balears";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 3;

        /// <inheritdoc />
        public override int Day { get; set; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_es_regional_holiday_ib0301";
    }
}