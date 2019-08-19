using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.SanMarino.Public
{
    /// <summary>
    /// The Feast of San Marino and the Republic
    /// </summary>
    public class FeastOfSanMarinoAndTheRepublic : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.SanMarino;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.SanMarino;

        /// <inheritdoc />
        public override string Name { get; } = "The Feast of San Marino and the Republic";

        /// <inheritdoc />
        public override int Month { get; set; } = 9;

        /// <inheritdoc />
        public override int Day { get; set; } = 3;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_sm_feast_republic";
    }
}