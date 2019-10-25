using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.CapeVerde.Tradition
{
    /// <summary>
    /// All Saints' Day<br />
    /// pt: Todos os santos
    /// </summary>
    public class AllSaintsDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.CapeVerde;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.CapeVerde;

        /// <inheritdoc />
        public override string Name { get; } = "Todos os santos";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Tradition;

        /// <inheritdoc />
        public override int Month { get; set; } = 11;

        /// <inheritdoc />
        public override int Day { get; set; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cv_all_saints";
    }
}