using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Canada.Public
{
    /// <summary>
    /// November 11
    /// </summary>
    public class RemembranceDay : WeekShiftVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Canada;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Canada;

        /// <inheritdoc />
        public override List<string> RegionCodes { get; set; } = new List<string>
        {
            "CA-AB", "CA-BC", "CA-NB", "CA-NT", "CA-NS",
            "CA-NU", "CA-PE", "CA-SK", "CA-YT"
        };

        /// <inheritdoc />
        public override string Name { get; } = "Remembrance Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ca_remembrance";

        /// <inheritdoc />
        public override int Month { get; } = 11;

        /// <inheritdoc />
        public override int Day { get; } = 11;

        /// <inheritdoc />
        protected override int SaturdayShift { get; } = 2;

        /// <inheritdoc />
        protected override int SundayShift { get; } = 1;
    }
}