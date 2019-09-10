using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.AntiguaAndBarbuda.Commemoration
{
    /// <summary>
    /// V.C Bird Day
    /// </summary>
    public class VcBirdDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.AntiguaAndBarbuda;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.AntiguaAndBarbuda;

        /// <inheritdoc />
        public override string Name { get; } = "V.C Bird Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 12;

        /// <inheritdoc />
        public override int Day { get; set; } = 9;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ag_vc_bird";
    }
}