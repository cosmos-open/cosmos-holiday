using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Mongolia.Public
{
    /// <summary>
    /// Naadam Holiday
    /// </summary>
    public class NaadamHoliday71 : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Mongolia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Mongolia;

        /// <inheritdoc />
        public override string Name { get; } = "Наадам";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override (int Month, int Day)? FromDate { get; set; } = (7, 11);

        /// <inheritdoc />
        public override (int Month, int Day)? ToDate { get; set; } = (7, 15);

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_mn_naadam_holiday_71";
    }
}