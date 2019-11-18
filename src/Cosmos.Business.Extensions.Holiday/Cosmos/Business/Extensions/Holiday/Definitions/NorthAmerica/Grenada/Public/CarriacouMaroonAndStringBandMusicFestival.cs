using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Grenada.Public
{
    /// <summary>
    /// Carriacou Maroon and String Band Music Festival
    /// </summary>
    public class CarriacouMaroonAndStringBandMusicFestival : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Grenada;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Grenada;

        /// <inheritdoc />
        public override string Name { get; } = "Carriacou Maroon and String Band Music Festival";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 4;

        /// <inheritdoc />
        public override int Day { get; set; } = 24;

        /// <inheritdoc />
        public override int Length { get; } = 3;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_gd_carriacou_maroon_and_string_band_music";
    }
}