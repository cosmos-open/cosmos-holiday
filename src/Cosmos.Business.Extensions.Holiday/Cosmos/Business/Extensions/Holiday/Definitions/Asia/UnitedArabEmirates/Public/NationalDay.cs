using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.UnitedArabEmirates.Public
{
    /// <summary>
    /// National Day
    /// </summary>
    public class NationalDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.UnitedArabEmirates;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.UnitedArabEmirates;

        /// <inheritdoc />
        public override string Name { get; } = "اليوم الوطني";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override (int Month, int Day)? FromDate { get; set; } = (12, 2);

        /// <inheritdoc />
        public override (int Month, int Day)? ToDate { get; set; } = (12, 3);

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ae_national";
    }
}