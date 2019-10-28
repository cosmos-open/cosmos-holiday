using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Estonia.Public
{
    /// <summary>
    /// Day of Mourning and Commemoration<br />
    /// et: leinapäev
    /// </summary>
    public class DayOfMourningAndCommemoration: BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Estonia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Estonia;

        /// <inheritdoc />
        public override string Name { get; } = "leinapäev";

        /// <inheritdoc />
        public override int Month { get; set; } = 6;

        /// <inheritdoc />
        public override int Day { get; set; } = 14;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ee_mourning_commemoration";
    }
}