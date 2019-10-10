using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Globalization;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Brunei.Religion
{
    /// <summary>
    /// Muhammad's Ascension to Heaven<br />
    /// ms: Israk dan Mikraj
    /// </summary>
    public class MuhammadsAscensionToHeaven: IslamicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Brunei;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Brunei;

        /// <inheritdoc />
        public override string Name { get; } = "Israk dan Mikraj";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override IslamicMonths IslamicMonth { get; set; } = IslamicMonths.Rajab;

        /// <inheritdoc />
        protected override int IslamicDay { get; set; } = 27;
        
        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bn_muhammads_ascension_to_heaven";
    }
}