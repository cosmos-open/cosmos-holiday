using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Estonia.Public
{
    /// <summary>
    /// Native Language Day<br />
    /// et: emakeelepäev
    /// </summary>
    public class NativeLanguageDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Estonia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Estonia;

        /// <inheritdoc />
        public override string Name { get; } = "emakeelepäev";

        /// <inheritdoc />
        public override int Month { get; set; } = 3;

        /// <inheritdoc />
        public override int Day { get; set; } = 14;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ee_native_language";
    }
}