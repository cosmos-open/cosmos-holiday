using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Barbados.Religion
{
    /// <summary>
    /// Boxing Day
    /// </summary>
    public class BoxingDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Barbados;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Barbados;

        /// <inheritdoc />
        public override string Name { get; } = "Boxing Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override int Month { get; set; } = 12;

        /// <inheritdoc />
        public override int Day { get; set; } = 26;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bb_boxing";
    }
}