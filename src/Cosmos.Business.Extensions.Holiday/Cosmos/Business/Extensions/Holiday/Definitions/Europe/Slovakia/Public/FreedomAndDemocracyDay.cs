using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Slovakia.Public
{
    /// <summary>
    /// Struggle for Freedom and Democracy Day
    /// </summary>
    public class FreedomAndDemocracyDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Slovakia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Slovakia;

        /// <inheritdoc />
        public override string Name { get; } = "Deň boja za slobodu a demokraciu";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 11;

        /// <inheritdoc />
        public override int Day { get; set; } = 17;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_sk_freedom_and_democracy";
    }
}