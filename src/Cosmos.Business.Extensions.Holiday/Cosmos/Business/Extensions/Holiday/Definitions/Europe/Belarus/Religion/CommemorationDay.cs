using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Belarus.Religion
{
    /// <summary>
    /// Commemoration Day
    /// </summary>
    public class CommemorationDay : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Belarus;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Belarus;

        /// <inheritdoc />
        public override string Name { get; } = "Радунiца";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = 9;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_by_commemoration";
    }
}