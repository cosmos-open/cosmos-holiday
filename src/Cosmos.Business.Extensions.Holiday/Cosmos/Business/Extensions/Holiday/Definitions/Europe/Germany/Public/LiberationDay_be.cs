using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Germany.Public
{
    /// <summary>
    /// Liberation Day<br />
    /// de: Tag der Befreiung
    /// </summary>
    public class LiberationDayBe : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Germany;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Germany;

        /// <inheritdoc />
        public override string RegionCode { get; } = "DE-BE";

        /// <inheritdoc />
        public override string Name { get; } = "Tag der Befreiung";

        /// <inheritdoc />
        public override int Month { get; set; } = 5;

        /// <inheritdoc />
        public override int Day { get; set; } = 8;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_de_liberation";

        /// <inheritdoc />
        protected override int? OnlyYear { get; set; } = 2020;
    }
}