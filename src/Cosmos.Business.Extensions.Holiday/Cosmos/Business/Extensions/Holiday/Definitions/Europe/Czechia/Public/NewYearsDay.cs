using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Czechia.Public
{
    /// <summary>
    /// New Year's Day<br />
    /// cz: Nový rok; Den obnovy samostatného českého státu
    /// </summary>
    public class NewYearsDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Czechia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Czechia;

        /// <inheritdoc />
        public override string Name { get; } = "Nový rok; Den obnovy samostatného českého státu";

        /// <inheritdoc />
        public override int Month { get; set; } = 1;

        /// <inheritdoc />
        public override int Day { get; set; } = 1;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cz_new_year";
    }
}