using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Burundi.Public
{
    /// <summary>
    /// Rwagasore Day<br />
    /// fr: Jour de Rwagasore
    /// </summary>
    public class RwagasoreDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Burundi;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Burundi;

        /// <inheritdoc />
        public override string Name { get; } = "Jour de Rwagasore";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 10;

        /// <inheritdoc />
        public override int Day { get; set; } = 13;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bi_rwagasore";
    }
}