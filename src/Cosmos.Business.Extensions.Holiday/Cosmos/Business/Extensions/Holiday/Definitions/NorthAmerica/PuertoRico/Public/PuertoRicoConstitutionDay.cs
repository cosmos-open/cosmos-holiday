using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.PuertoRico.Public
{
    /// <summary>
    /// Puerto Rico Constitution Day
    /// </summary>
    public class PuertoRicoConstitutionDay : BaseFixedHolidayFunc
    {

        /// <inheritdoc />
        public override Country Country { get; } = Country.PuertoRico;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.UnitedStates;

        /// <inheritdoc />
        public override string Name { get; } = "Constitución de Puerto Rico";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 7;

        /// <inheritdoc />
        public override int Day { get; set; } = 25;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_pr_constitution";
    }
}