using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.SaintBarts.Religion
{
    /// <summary>
    /// Laetare Sunday<br />
    /// fr: Mi-Carême
    /// </summary>
    public class LaetareSunday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.SaintBarts;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.France;

        /// <inheritdoc />
        public override string Name { get; } = "Mi-Carême";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = -21;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bl_laetare_sunday";
    }
}