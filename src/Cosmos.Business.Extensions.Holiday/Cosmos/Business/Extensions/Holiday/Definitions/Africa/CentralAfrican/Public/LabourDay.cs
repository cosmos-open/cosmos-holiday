using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.CentralAfrican.Public
{
    /// <summary>
    /// Labour Day<br />
    /// fr: Fête du travail
    /// </summary>
    public class LabourDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.CentralAfrican;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.CentralAfrican;

        /// <inheritdoc />
        public override string Name { get; } = "Fête du travail";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 5;

        /// <inheritdoc />
        public override int Day { get; set; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cf_labour";
    }
}