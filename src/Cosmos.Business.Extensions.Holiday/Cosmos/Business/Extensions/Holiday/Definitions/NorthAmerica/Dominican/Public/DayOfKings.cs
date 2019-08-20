using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Dominican.Public
{
    /// <summary>
    /// Day of Kings
    /// </summary>
    public class DayOfKings : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Dominican;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Dominican;

        /// <inheritdoc />
        public override string Name { get; } = "Dia de Reyes";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 1;

        /// <inheritdoc />
        public override int Day { get; set; } = 6;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_do_king";
    }
}