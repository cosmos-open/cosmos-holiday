using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Somalia.Public
{
    /// <summary>
    /// Restoration of Somaliland Sovereignty
    /// </summary>
    public class RestorationOfSomalilandSovereignty : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Somalia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Somalia;

        /// <inheritdoc />
        public override List<string> RegionCodes { get; set; } = new List<string> {"SO-AW", "SO-SA", "SO-SO", "SO-TO", "SO-WO"};

        /// <inheritdoc />
        public override string Name { get; } = "Labour Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 5;

        /// <inheritdoc />
        public override int Day { get; set; } = 18;

        /// <inheritdoc />
        public override int Length { get; } = 2;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_so_sovereignty";
    }
}