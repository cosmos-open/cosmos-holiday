using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Cuba.Commemoration
{
    /// <summary>
    /// Day after the Commemoration of the Assault of the Moncada garrison
    /// </summary>
    public class AssaultOfTheMoncadaGarrisonAfter : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Cuba;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Cuba;

        /// <inheritdoc />
        public override string Name { get; } = "Conmemoración del asalto a Moncada";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 7;

        /// <inheritdoc />
        public override int Day { get; set; } = 27;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cu_assault_moncada_after";
    }
}