using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Honduras.Public
{
    /// <summary>
    /// Francisco Morazán's Day
    /// </summary>
    public class FranciscoMorazánsDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Honduras;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Honduras;

        /// <inheritdoc />
        public override string Name { get; } = "Francisco Morazán's Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 10;

        /// <inheritdoc />
        public override int Day { get; set; } = 3;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_hn_francisco_morazans";
    }
}