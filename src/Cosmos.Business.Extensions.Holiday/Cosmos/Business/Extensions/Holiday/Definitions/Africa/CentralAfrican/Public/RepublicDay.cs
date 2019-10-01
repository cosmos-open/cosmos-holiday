using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.CentralAfrican.Public
{
    /// <summary>
    /// Republic Day<br />
    /// fr: Jour de la République
    /// </summary>
    public class RepublicDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.CentralAfrican;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.CentralAfrican;

        /// <inheritdoc />
        public override string Name { get; } = "Jour de la République";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 12;

        /// <inheritdoc />
        public override int Day { get; set; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cf_republic";
    }
}