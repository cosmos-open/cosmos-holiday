using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Bahrain.Public
{
    /// <summary>
    /// New Year's Day<br />
    /// ar: 'عيد رأس السنة'
    /// </summary>
    public class NewYearsDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Bahrain;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Bahrain;

        /// <inheritdoc />
        public override string Name { get; } = "'عيد رأس السنة'";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 1;

        /// <inheritdoc />
        public override int Day { get; set; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bh_new_year";
    }
}