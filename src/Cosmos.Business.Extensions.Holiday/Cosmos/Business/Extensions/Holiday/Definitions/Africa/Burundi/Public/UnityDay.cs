using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Burundi.Public
{
    /// <summary>
    /// Unity Day<br />
    /// fr:Jour de l'Unité
    /// </summary>
    public class UnityDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Burundi;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Burundi;

        /// <inheritdoc />
        public override string Name { get; } = "Jour de l'Unité";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 2;

        /// <inheritdoc />
        public override int Day { get; set; } = 5;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bi_unity";
    }
}