using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Czechia.Public
{
    /// <summary>
    /// Den znárodnění - Nationalization Day
    /// Old public holiday during the communist era: 1952-1974
    /// introduced in 1952 (by 93/1951 Sb.), cancelled in 1975 (last holiday was 1974)
    /// </summary>
    public class NationalizationDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Czechia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Czechia;

        /// <inheritdoc />
        public override string Name { get; } = "Den znárodnění";

        /// <inheritdoc />
        public override int Month { get; set; } = 10;

        /// <inheritdoc />
        public override int Day { get; set; } = 28;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cz_nationalization_day";

        /// <inheritdoc />
        public override int? Since { get; } = 1952;

        /// <inheritdoc />
        public override int? End { get; } = 1974;
    }
}