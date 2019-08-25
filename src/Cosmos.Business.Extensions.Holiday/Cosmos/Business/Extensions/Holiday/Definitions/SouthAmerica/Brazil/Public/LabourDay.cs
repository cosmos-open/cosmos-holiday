using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Brazil.Public
{
    /// <summary>
    /// Labour Day
    /// </summary>
    public class LabourDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Brazil;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Brazil;

        /// <inheritdoc />
        public override string Name { get; } = "Dia do Trabalhador";

        /// <inheritdoc />
        public override int Month { get; set; } = 5;

        /// <inheritdoc />
        public override int Day { get; set; } = 1;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_br_labour";
    }
}