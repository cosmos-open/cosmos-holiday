using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Peru.Public
{
    /// <summary>
    /// Paraguayan Independence
    /// </summary>
    public class IndependenceDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Peru;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Peru;

        /// <inheritdoc />
        public override string Name { get; } = "Día de la Independencia";

        /// <inheritdoc />
        public override (int Month, int Day)? FromDate { get; set; } = (7, 28);

        /// <inheritdoc />
        public override (int Month, int Day)? ToDate { get; set; } = (7, 29);

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_pe_independence";
    }
}