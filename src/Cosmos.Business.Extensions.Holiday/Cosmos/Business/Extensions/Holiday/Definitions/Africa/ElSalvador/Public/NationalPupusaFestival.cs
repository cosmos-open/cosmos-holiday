using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.ElSalvador.Public
{
    /// <summary>
    /// National Pupusa Festival
    /// </summary>
    public class NationalPupusaFestival: BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.ElSalvador;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.ElSalvador;

        /// <inheritdoc />
        public override string Name { get; } = "Festival Nacional De La Pupusa";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override (int Month, int Day)? FromDate { get; set; } = (11, 7);

        /// <inheritdoc />
        public override (int Month, int Day)? ToDate { get; set; } = (11, 13);

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_sv_national_pupusa_festival";
    }
}