using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Tunisia.Commemoration
{
    /// <summary>
    /// Eid El Jala
    /// </summary>
    public class EidElJala : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Tunisia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Tunisia;

        /// <inheritdoc />
        public override string Name { get; } = "Eid El Jala";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 10;

        /// <inheritdoc />
        public override int Day { get; set; } = 15;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_tn_eid_el_jala";
    }
}