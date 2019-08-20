using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.CostaRica.Commemoration
{
    /// <summary>
    /// Mother´s Day
    /// </summary>
    public class MothersDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.CostaRica;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.CostaRica;

        /// <inheritdoc />
        public override string Name { get; } = "Mother´s Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 8;

        /// <inheritdoc />
        public override int Day { get; set; } = 15;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cr_mother";
    }
}