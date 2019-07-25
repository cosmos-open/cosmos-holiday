using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Spain.Public
{
    /// <summary>
    /// Regional Holiday
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public class RegionalHoliday__m0502 : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Spain;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Spain;

        /// <inheritdoc />
        public override string RegionCode { get; } = "ES-M";

        /// <inheritdoc />
        public override string Name { get; } = "Fiesta de la Comunidad de Madrid";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 5;

        /// <inheritdoc />
        public override int Day { get; set; } = 2;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_es_regional_holiday_m0502";
    }
}