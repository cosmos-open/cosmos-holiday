using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Burundi.Public
{
    /// <summary>
    /// Independence Day<br />
    /// fr: Jour de l'Indépendance
    /// </summary>
    public class IndependenceDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Burundi;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Burundi;

        /// <inheritdoc />
        public override string Name { get; } = "Jour de l'Indépendance";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 7;

        /// <inheritdoc />
        public override int Day { get; set; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bi_independence";
    }
}