using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Czechia.Tradition
{
    /// <summary>
    /// Svátek Všech Svatých - All Saints’ Day
    /// Cancelled since 1952
    /// </summary>
    public class AllSaintsDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Czechia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Czechia;

        /// <inheritdoc />
        public override string Name { get; } = "Svátek Všech Svatých";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Tradition;

        /// <inheritdoc />
        public override int Month { get; set; } = 11;

        /// <inheritdoc />
        public override int Day { get; set; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cz_all_saints";

        /// <inheritdoc />
        public override int? Since { get; set; } = 1952;
    }
}