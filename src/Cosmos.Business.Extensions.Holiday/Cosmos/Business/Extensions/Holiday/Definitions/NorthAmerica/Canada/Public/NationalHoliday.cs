using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Canada.Public
{
    /// <summary>
    /// National holiday (June 24)
    /// </summary>
    public class NationalHoliday : WeekShiftVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Canada;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Canada;

        /// <inheritdoc />
        public override List<string> RegionCodes { get; set; } = new List<string> {"CA-NL", "CA-QC", "CA-YT"};

        /// <inheritdoc />
        public override string Name { get; } = "National Holiday";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ca_national_holiday";

        /// <inheritdoc />
        public override int Month { get; } = 6;

        /// <inheritdoc />
        public override int Day { get; } = 24;

        /// <inheritdoc />
        protected override int SaturdayShift { get; } = 2;

        /// <inheritdoc />
        protected override int SundayShift { get; } = 1;
    }
}