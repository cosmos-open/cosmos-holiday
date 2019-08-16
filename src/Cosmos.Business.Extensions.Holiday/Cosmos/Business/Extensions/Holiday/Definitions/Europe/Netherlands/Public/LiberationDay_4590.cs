using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Netherlands.Public
{
    /// <summary>
    /// Liberation Day
    /// </summary>
    public class LiberationDay4590 : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Netherlands;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Netherlands;

        /// <inheritdoc />
        public override string Name { get; } = "Bevrijdingsdag";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 5;

        /// <inheritdoc />
        public override int Day { get; set; } = 5;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_nl_lberation_4590";

        /// <inheritdoc />
        public override int? Since { get; } = 1945;

        /// <inheritdoc />
        public override int? End { get; } = 1989;

        /// <inheritdoc />
        public override int? TimeStepValue { get; } = 5;
    }
}