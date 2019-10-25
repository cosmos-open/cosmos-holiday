using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Cameroun.Public
{
    /// <summary>
    /// National Day<br />
    /// fr: Fête nationale ou de l'unité
    /// </summary>
    public class NationalDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Cameroun;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Cameroun;

        /// <inheritdoc />
        public override string Name { get; } = "Fête nationale ou de l'unité";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 5;

        /// <inheritdoc />
        public override int Day { get; set; } = 20;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cm_national";
    }
}