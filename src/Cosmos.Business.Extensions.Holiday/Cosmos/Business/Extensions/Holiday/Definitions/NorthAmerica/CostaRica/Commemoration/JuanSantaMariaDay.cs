using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.CostaRica.Commemoration
{
    /// <summary>
    /// Juan Santa maria Day
    /// </summary>
    public class JuanSantaMariaDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.CostaRica;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.CostaRica;

        /// <inheritdoc />
        public override string Name { get; } = "Juan Santa maria Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 4;

        /// <inheritdoc />
        public override int Day { get; set; } = 11;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cr_juan_santa_maria";
    }
}