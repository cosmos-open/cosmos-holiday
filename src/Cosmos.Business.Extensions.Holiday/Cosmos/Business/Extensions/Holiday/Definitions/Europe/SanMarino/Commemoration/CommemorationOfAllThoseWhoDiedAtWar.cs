using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.SanMarino.Commemoration
{
    /// <summary>
    /// Commemoration of all those who died at war
    /// </summary>
    public class CommemorationOfAllThoseWhoDiedAtWar : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.SanMarino;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.SanMarino;

        /// <inheritdoc />
        public override string Name { get; } = "Commemoration of all those who died at war";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 11;

        /// <inheritdoc />
        public override int Day { get; set; } = 2;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_sm_commemoration_all";
    }
}