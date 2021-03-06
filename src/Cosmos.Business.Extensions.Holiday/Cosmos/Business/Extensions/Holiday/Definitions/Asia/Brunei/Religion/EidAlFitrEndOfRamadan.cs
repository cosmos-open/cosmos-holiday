using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Globalization;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Brunei.Religion
{
    /// <summary>
    /// Eid Al Fitr End of Ramadan<br />
    /// ms: Hari Raya Aidil Fitri
    /// </summary>
    public class EidAlFitrEndOfRamadan : IslamicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Brunei;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Brunei;

        /// <inheritdoc />
        public override string Name { get; } = "Hari Raya Aidil Fitri";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override (IslamicMonths Month, int Day)? FromIslamicDate { get; set; } = (IslamicMonths.Shawwal, 1);
        
        /// <inheritdoc />
        protected override (IslamicMonths Month, int Day)? ToIslamicDate { get; set; } = (IslamicMonths.Shawwal, 3);

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bn_eid_al_fitr_end_of_ramadan";
    }
}