using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Brunei.Public
{
    /// <summary>
    /// Armed Forces Day<br />
    /// ms: Hari Angkatan Bersenjata Diraja Brunei
    /// </summary>
    public class ArmyForcesDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Brunei;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Brunei;

        /// <inheritdoc />
        public override string Name { get; } = "Hari Angkatan Bersenjata Diraja Brunei";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 3;

        /// <inheritdoc />
        public override int Day { get; set; } = 31;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bn_army";
    }
}