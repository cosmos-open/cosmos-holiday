using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Czechia.Commemoration
{
    /// <summary>
    /// St. Wenceslas Day
    /// </summary>
    public class StWenceslasDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Czechia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Czechia;

        /// <inheritdoc />
        public override string Name { get; } = "Den české státnosti";

        /// <inheritdoc />
        public override int Month { get; set; } = 9;

        /// <inheritdoc />
        public override int Day { get; set; } = 28;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cz_wenceslas";
    }
}