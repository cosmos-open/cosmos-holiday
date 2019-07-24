using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Namibia.Public
{
    /// <summary>
    /// Human Rights Day
    /// </summary>
    public class HumanRightsDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Namibia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Namibia;

        /// <inheritdoc />
        public override string Name { get; } = "Human Rights Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 12;

        /// <inheritdoc />
        public override int Day { get; set; } = 10;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_na_human_rights";
    }
}