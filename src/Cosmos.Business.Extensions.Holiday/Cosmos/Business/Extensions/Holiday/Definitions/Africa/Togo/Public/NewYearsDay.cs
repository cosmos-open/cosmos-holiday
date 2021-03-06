using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Togo.Public
{
    /// <summary>
    /// New Year's Day<br />
    /// fr: Nouvel An
    /// </summary>
    public class NewYearsDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Togo;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Togo;

        /// <inheritdoc />
        public override string Name { get; } = "Nouvel An";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 1;

        /// <inheritdoc />
        public override int Day { get; set; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_tg_new_year";
    }
}