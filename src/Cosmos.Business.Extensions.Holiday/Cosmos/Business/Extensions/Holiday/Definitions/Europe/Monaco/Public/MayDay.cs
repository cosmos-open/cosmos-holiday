using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Monaco.Public
{
    /// <summary>
    /// May Day
    /// </summary>
    public class MayDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Monaco;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Monaco;

        /// <inheritdoc />
        public override string Name { get; } = "Le 1er mai";

        /// <inheritdoc />
        public override int Month { get; set; } = 5;

        /// <inheritdoc />
        public override int Day { get; set; } = 1;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_mc_may_day";
    }
}