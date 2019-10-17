using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.CocosIslands.Public
{
    /// <summary>
    /// Anzac Day
    /// </summary>
    public class AnzacDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.CocosIslands;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Australia;
        
        /// <inheritdoc />
        public override string Name { get; } = "Anzac Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 4;

        /// <inheritdoc />
        public override int Day { get; set; } = 25;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cc_anzac";
    }
}