using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Paraguay.Public
{
    /// <summary>
    /// Paraguayan Independence
    /// </summary>
    public class IndependenceDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Paraguay;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Paraguay;

        /// <inheritdoc />
        public override string Name { get; } = "Independencia";

        /// <inheritdoc />
        public override (int Month, int Day)? FromDate { get; set; } = (5, 14);

        /// <inheritdoc />
        public override (int Month, int Day)? ToDate { get; set; } = (5, 15);

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_py_independence";
    }
}