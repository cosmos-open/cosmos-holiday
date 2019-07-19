using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.ElSalvador.Public
{
    /// <summary>
    /// August Festivals
    /// </summary>
    public class AugustFestivals : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.ElSalvador;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.ElSalvador;

        /// <inheritdoc />
        public override string Name { get; } = "Fiestas de agosto";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override (int Month, int Day)? FromDate { get; set; } = (8, 1);

        /// <inheritdoc />
        public override (int Month, int Day)? ToDate { get; set; } = (8, 7);

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_sv_august";
    }
}