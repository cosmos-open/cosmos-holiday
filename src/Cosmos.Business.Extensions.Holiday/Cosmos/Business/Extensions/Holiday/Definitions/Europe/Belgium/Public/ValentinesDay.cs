using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Belgium.Public
{
    /// <summary>
    /// Valentine's Day<br />
    /// nl: Valentijnsdag
    /// de: Valentinstag
    /// fr: Saint-Valentin
    /// </summary>
    public class ValentinesDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Belgium;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Belgium;

        /// <inheritdoc />
        public override string Name { get; } = "Valentine's Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 2;

        /// <inheritdoc />
        public override int Day { get; set; } = 14;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_be_valentine";
    }
}