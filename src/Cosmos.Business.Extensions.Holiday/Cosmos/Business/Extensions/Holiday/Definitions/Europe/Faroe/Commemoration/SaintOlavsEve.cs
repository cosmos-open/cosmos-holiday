using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Faroe.Commemoration
{
    /// <summary>
    /// Saint Olav's Eve
    /// </summary>
    public class SaintOlavsEve : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Faroe;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Faroe;

        /// <inheritdoc />
        public override string Name { get; } = "Ólavsøkuaftan";

        /// <inheritdoc />
        public override int Month { get; set; } = 7;

        /// <inheritdoc />
        public override int Day { get; set; } = 28;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_fo_olavs_eve";
    }
}