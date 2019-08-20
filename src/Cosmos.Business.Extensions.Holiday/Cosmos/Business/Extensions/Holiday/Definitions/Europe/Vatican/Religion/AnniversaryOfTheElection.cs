using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Vatican.Religion
{
    /// <summary>
    /// Anniversary of the election of Pope Francis	
    /// </summary>
    public class AnniversaryOfTheElection : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Vatican;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Vatican;

        /// <inheritdoc />
        public override string Name { get; } = "Anniversario dell'Elezione del Santo Padre";

        /// <inheritdoc />
        public override int Month { get; set; } = 3;

        /// <inheritdoc />
        public override int Day { get; set; } = 13;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_va_anniversary_of_the_election";
    }
}