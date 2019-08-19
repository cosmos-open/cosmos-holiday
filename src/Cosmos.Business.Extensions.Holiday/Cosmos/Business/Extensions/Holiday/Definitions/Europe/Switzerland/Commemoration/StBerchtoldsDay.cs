using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Switzerland.Commemoration
{
    /// <summary>
    /// January 2, Berchtoldstag
    /// <br />
    /// St. Berchtold's Day
    /// </summary>
    public class SecondJanuary : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Switzerland;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Switzerland;

        /// <inheritdoc />
        public override List<string> RegionCodes { get; set; } = new List<string>
        {
            "CH-ZH", "CH-BE", "CH-LU", "CH-OW", "CH-GL", "CH-ZG", "CH-FR",
            "CH-SO", "CH-SH", "CH-TG", "CH-VD", "CH-NE", "CH-GE", "CH-JU"
        };

        /// <inheritdoc />
        public override string Name { get; } = "Berchtoldstag";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 1;

        /// <inheritdoc />
        public override int Day { get; set; } = 2;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ch_berchtold";
    }
}