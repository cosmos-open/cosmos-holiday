using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Switzerland.Public
{
    /// <summary>
    /// Labour Day
    /// </summary>
    public class LabourDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Switzerland;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Switzerland;

        /// <inheritdoc />
        public override List<string> RegionCodes { get; set; } = new List<string>
        {
            "CH-ZH", "CH-FR", "CH-SO", "CH-BS", "CH-BL", "CH-SH",
            "CH-AG", "CH-TG", "CH-TI", "CH-NE", "CH-JU"
        };

        /// <inheritdoc />
        public override string Name { get; } = "Tag der Arbeit";

        /// <inheritdoc />
        public override int Month { get; set; } = 5;

        /// <inheritdoc />
        public override int Day { get; set; } = 1;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ch_labour";
    }
}