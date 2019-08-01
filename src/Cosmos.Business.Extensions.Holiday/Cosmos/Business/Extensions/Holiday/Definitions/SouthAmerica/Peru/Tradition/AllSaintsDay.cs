using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Peru.Tradition
{
    /// <summary>
    /// All Saints Day
    /// </summary>
    public class AllSaintsDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Peru;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Peru;

        /// <inheritdoc />
        public override string Name { get; } = "Día de Todos los Santos";

        /// <inheritdoc />
        public override int Month { get; set; } = 11;

        /// <inheritdoc />
        public override int Day { get; set; } = 1;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Tradition;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_py_all_saints";
    }
}