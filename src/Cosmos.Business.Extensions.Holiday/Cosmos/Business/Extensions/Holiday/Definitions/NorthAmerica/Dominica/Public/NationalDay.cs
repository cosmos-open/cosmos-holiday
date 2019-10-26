using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Dominica.Public
{
    /// <summary>
    /// National Day of Community Service
    /// </summary>
    public class NationalDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Dominica;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Dominica;

        /// <inheritdoc />
        public override string Name { get; } = "National Day of Community Service";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 11;

        /// <inheritdoc />
        public override int Day { get; set; } = 4;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_dm_national_day";
    }
}