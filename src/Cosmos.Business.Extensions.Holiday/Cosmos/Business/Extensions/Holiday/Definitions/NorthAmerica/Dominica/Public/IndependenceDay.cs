using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Dominica.Public
{
    /// <summary>
    /// Independence Day
    /// </summary>
    public class IndependenceDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Dominica;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Dominica;

        /// <inheritdoc />
        public override string Name { get; } = "Independence Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 11;

        /// <inheritdoc />
        public override int Day { get; set; } = 3;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_dm_independence";
    }
}