using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Oceania.NewZealand.Public
{
    /// <summary>
    /// Anzac Day (before 2015)
    /// </summary>
    public class AnzacDay2014B : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.NewZealand;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.NewZealand;

        /// <inheritdoc />
        public override string Name { get; } = "Anzac Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 4;

        /// <inheritdoc />
        public override int Day { get; set; } = 25;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_nz_anzac_2014b";

        /// <inheritdoc />
        public override int? End { get; } = 2014;
    }
}