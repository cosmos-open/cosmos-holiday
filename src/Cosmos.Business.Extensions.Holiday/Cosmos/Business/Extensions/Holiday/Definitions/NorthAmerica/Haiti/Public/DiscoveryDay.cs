using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Haiti.Public
{
    /// <summary>
    /// Discovery Day
    /// </summary>
    public class DiscoveryDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Haiti;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Haiti;

        /// <inheritdoc />
        public override string Name { get; } = "Découverte d'Haïti";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 12;

        /// <inheritdoc />
        public override int Day { get; set; } = 5;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ht_discovery";
    }
}