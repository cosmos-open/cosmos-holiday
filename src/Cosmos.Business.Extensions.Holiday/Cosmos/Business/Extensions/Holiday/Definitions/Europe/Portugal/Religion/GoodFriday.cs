using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Portugal.Religion
{
    /// <summary>
    /// Good Friday
    /// </summary>
    public class GoodFriday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Portugal;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Portugal;

        /// <inheritdoc />
        public override string Name { get; } = "Sexta-feira Santa";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = -2;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_pt_good_friday";
    }
}