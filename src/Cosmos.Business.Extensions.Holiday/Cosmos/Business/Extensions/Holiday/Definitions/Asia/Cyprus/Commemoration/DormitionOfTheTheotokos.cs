using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Cyprus.Commemoration
{
    /// <summary>
    /// Dormition of the Theotokos
    /// </summary>
    public class DormitionOfTheTheotokos : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Cyprus;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Cyprus;

        /// <inheritdoc />
        public override string Name { get; } = "Dormition of the Theotokos";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 8;

        /// <inheritdoc />
        public override int Day { get; set; } = 15;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cy_dormition_theotokos";
    }
}