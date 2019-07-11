using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Czechia.Public
{
    /// <summary>
    /// Den boje za svobodu a demokracii - Struggle for Freedom and Democracy Day
    /// Commemorating the student demonstration against Nazi occupation in 1939, 
    /// and especially the demonstration in 1989 in Bratislava and Prague 
    /// considered to mark the beginning of the Velvet Revolution.
    /// valid since 2000, since the new law (245/2000 Sb.) was introduced , replacing the old law 93/1951 Sb.
    /// </summary>
    public class FreedomDemocracyDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Czechia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Czechia;

        /// <inheritdoc />
        public override string Name { get; } = "Den boje za svobodu a demokracii";

        /// <inheritdoc />
        public override int Month { get; set; } = 10;

        /// <inheritdoc />
        public override int Day { get; set; } = 28;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cz_independent_day";

        /// <inheritdoc />
        public override int? Since { get; } = 1988;
    }
}