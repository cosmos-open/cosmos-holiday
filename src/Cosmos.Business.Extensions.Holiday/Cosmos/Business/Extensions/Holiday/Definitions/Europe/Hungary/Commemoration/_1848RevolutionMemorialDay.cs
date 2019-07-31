using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Hungary.Commemoration
{
    /// <summary>
    /// 1848 Revolution Memorial Day
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public class _1848RevolutionMemorialDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Hungary;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Hungary;

        /// <inheritdoc />
        public override string Name { get; } = "Nemzeti ünnep";

        /// <inheritdoc />
        public override int Month { get; set; } = 3;

        /// <inheritdoc />
        public override int Day { get; set; } = 15;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_hu_1848";
    }
}