using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Suriname.Public
{
    /// <summary>
    /// Indigenous People's Day
    /// </summary>
    public class IndigenousPeoplesDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Suriname;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Suriname;

        /// <inheritdoc />
        public override string Name { get; } = "Indigenous People's Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 8;

        /// <inheritdoc />
        public override int Day { get; set; } = 9;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_sr_indigenous_people";
    }
}