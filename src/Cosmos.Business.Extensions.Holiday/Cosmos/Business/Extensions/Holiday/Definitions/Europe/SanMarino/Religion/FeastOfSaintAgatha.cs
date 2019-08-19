using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.SanMarino.Religion
{
    /// <summary>
    /// Feast of Saint Agatha
    /// </summary>
    public class FeastOfSaintAgatha : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.SanMarino;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.SanMarino;

        /// <inheritdoc />
        public override string Name { get; } = "Feast of Saint Agatha";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override int Month { get; set; } = 2;

        /// <inheritdoc />
        public override int Day { get; set; } = 5;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_sm_feast_of_saint_agatha";
    }
}