using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Switzerland.Religion
{
    /// <summary>
    /// Good Friday
    /// </summary>
    public class GoodFriday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Switzerland;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Switzerland;

        /// <inheritdoc />
        public override List<string> RegionCodes { get; set; } = new List<string>
        {
            "CH-ZH", "CH-BE", "CH-LU", "CH-UR", "CH-SZ", "CH-OW",
            "CH-NW", "CH-GL", "CH-ZG", "CH-FR", "CH-SO", "CH-BS",
            "CH-BL", "CH-SH", "CH-AR", "CH-AI", "CH-SG", "CH-GR",
            "CH-AG", "CH-TG", "CH-VD", "CH-NE", "CH-GE", "CH-JU"
        };

        /// <inheritdoc />
        public override string Name { get; } = "Karfreitag";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = -2;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ch_good_friday";
    }
}