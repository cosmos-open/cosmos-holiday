using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Gibraltar.Public
{
    /// <summary>
    /// Gibraltar National Day
    /// </summary>
    public class GibraltarNationalDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Gibraltar;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.UnitedKingdom;

        /// <inheritdoc />
        public override string Name { get; } = "Gibraltar National Day";

        /// <inheritdoc />
        public override int Month { get; set; } = 9;

        /// <inheritdoc />
        public override int Day { get; set; } = 10;

        /// <inheritdoc />
        public override int? Since { get; set; } = 2015;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_gi_national";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

    }
}