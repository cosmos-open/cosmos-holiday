using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Somalia.Public
{
    /// <summary>
    /// Independence of British Somaliland
    /// </summary>
    public class IndependenceOfBritishSomaliland : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Somalia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Somalia;

        /// <inheritdoc />
        public override string Name { get; } = "Independence of British Somaliland";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 6;

        /// <inheritdoc />
        public override int Day { get; set; } = 26;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_so_independence_of_british_somaliland";
    }
}