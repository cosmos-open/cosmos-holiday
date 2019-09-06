using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Angola.Commemoration
{
    /// <summary>
    /// All Souls' Day
    /// </summary>
    public class AllSoulsDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Angola;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Angola;

        /// <inheritdoc />
        public override string Name { get; } = "Dia de Finados";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 11;

        /// <inheritdoc />
        public override int Day { get; set; } = 2;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ao_all_souls";
    }
}