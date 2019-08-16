using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Portugal.Public
{
    /// <summary>
    /// Restoration of Independence
    /// </summary>
    public class RestorationOfIndependence : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Portugal;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Portugal;

        /// <inheritdoc />
        public override string Name { get; } = "Restauração da Independência";

        /// <inheritdoc />
        public override int Month { get; set; } = 12;

        /// <inheritdoc />
        public override int Day { get; set; } = 1;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_pt_independence_restoration";
    }
}