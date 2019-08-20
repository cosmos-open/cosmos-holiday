using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Dominican.Commemoration
{
    /// <summary>
    /// Our Lady of Mercy
    /// </summary>
    public class OurLadyOfMercy : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Dominican;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Dominican;

        /// <inheritdoc />
        public override string Name { get; } = "Nuestra Senora de las Mercedes";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 9;

        /// <inheritdoc />
        public override int Day { get; set; } = 24;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_do_our_lady_mercy";
    }
}