using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Bangladesh.Public
{
    /// <summary>
    /// Genocide Remembrance Day
    /// </summary>
    public class GenocideRemembranceDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Bangladesh;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Bangladesh;

        /// <inheritdoc />
        public override string Name { get; } = "Genocide Remembrance Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 3;

        /// <inheritdoc />
        public override int Day { get; set; } = 25;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bd_genocide_remembrance";
    }
}