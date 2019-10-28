using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Estonia.Commemoration
{
    /// <summary>
    /// Anniversary of the Tartu Peace Treaty<br />
    /// et: Tartu rahulepingu aastapäev
    /// </summary>
    public class AnniversaryOfTheTartuPeaceTreaty : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Estonia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Estonia;

        /// <inheritdoc />
        public override string Name { get; } = "Tartu rahulepingu aastapäev";

        /// <inheritdoc />
        public override int Month { get; set; } = 2;

        /// <inheritdoc />
        public override int Day { get; set; } = 2;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ee_anniversary_of_tartu_peace_treaty";
    }
}