using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Portugal.Religion
{
    /// <summary>
    /// St. Stephen's Day
    /// </summary>
    public class StStephensDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Portugal;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Portugal;

        /// <inheritdoc />
        public override List<string> RegionCodes { get; set; } = new List<string>
        {
            "PT-01", "PT-02", "PT-03", "PT-04", "PT-05", "PT-06", "PT-07",
            "PT-08", "PT-09", "PT-10", "PT-11", "PT-12", "PT-13", "PT-14",
            "PT-15", "PT-16", "PT-17", "PT-18", "PT-20"
        };

        /// <inheritdoc />
        public override string Name { get; } = "Segunda Oitava";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override int Month { get; set; } = 12;

        /// <inheritdoc />
        public override int Day { get; set; } = 26;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_pt_stephen";
    }
}