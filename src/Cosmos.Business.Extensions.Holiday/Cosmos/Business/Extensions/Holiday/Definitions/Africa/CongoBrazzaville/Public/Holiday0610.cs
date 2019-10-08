using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.CongoBrazzaville.Public
{
    /// <summary>
    /// Fête de la commémoration de la conférence nationale souveraine<br />
    /// 纪念主权国家代表大会的盛宴
    /// </summary>
    public class Holiday0610 : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.CongoBrazzaville;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.CongoBrazzaville;

        /// <inheritdoc />
        public override string Name { get; } = "Fête de la commémoration de la conférence nationale souveraine";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 6;

        /// <inheritdoc />
        public override int Day { get; set; } = 10;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cg_0610";
    }
}