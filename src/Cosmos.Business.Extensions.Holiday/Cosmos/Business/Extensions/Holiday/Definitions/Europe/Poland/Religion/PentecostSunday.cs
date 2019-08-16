using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Poland.Religion
{
    /// <summary>
    /// Pentecost Sunday
    /// </summary>
    public class PentecostSunday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Poland;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Poland;

        /// <inheritdoc />
        public override string Name { get; } = "Zielone Świątki";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = 7 * 7;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_pl_pentecost_sunday";
    }
}