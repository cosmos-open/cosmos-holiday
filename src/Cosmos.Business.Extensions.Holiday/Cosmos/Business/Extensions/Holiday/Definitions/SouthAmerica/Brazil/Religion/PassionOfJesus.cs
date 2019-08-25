using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Brazil.Religion
{
    /// <summary>
    /// Passion of Jesus
    /// </summary>
    public class PassionOfJesus : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Brazil;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Brazil;

        /// <inheritdoc />
        public override string Name { get; } = "Sexta feira Santa";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = -2;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_br_passion_of_jesus";
    }
}