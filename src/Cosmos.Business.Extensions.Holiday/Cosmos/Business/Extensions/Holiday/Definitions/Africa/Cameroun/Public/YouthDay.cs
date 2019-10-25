using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Cameroun.Public
{
    /// <summary>
    /// Youth Day<br />
    /// fr: Fête de la Jeunesse
    /// </summary>
    public class YouthDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Cameroun;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Cameroun;

        /// <inheritdoc />
        public override string Name { get; } = "Fête de la Jeunesse";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 2;

        /// <inheritdoc />
        public override int Day { get; set; } = 11;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cm_youth";
    }
}