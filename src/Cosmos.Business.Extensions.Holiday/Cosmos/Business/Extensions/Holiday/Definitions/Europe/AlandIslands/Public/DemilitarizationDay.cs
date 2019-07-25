using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.AlandIslands.Public
{
    /// <summary>
    /// Demilitarization Day
    /// </summary>
    public class DemilitarizationDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.AlandIslands;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Finland;

        /// <inheritdoc />
        public override string Name { get; } = "Ålands demilitariseringsdag";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 3;

        /// <inheritdoc />
        public override int Day { get; set; } = 30;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ax_demilitarization";
    }
}