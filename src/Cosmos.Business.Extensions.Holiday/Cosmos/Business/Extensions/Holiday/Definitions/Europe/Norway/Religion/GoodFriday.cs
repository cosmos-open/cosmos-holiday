using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Norway.Religion
{
    /// <summary>
    /// Good Friday
    /// </summary>
    public class GoodFriday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Norway;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Norway;

        /// <inheritdoc />
        public override string Name { get; } = "Langfredag";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = -2;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_no_good_friday";
    }
}