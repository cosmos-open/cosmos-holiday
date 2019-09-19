using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.BurkinaFaso.Tradition
{
    /// <summary>
    /// All Saints' Day<br />
    /// fr: Toussaint
    /// </summary>
    public class AllSaintsDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.BurkinaFaso;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.BurkinaFaso;

        /// <inheritdoc />
        public override string Name { get; } = "Toussaint";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Tradition;

        /// <inheritdoc />
        public override int Month { get; set; } = 11;

        /// <inheritdoc />
        public override int Day { get; set; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_af_all_saints";
    }
}