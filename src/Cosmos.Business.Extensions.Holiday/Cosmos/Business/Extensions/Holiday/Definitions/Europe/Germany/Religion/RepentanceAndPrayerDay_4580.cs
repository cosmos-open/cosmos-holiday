using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Germany.Religion
{
    /// <summary>
    /// Repentance and Prayer Day
    /// </summary>
    public class RepentanceAndPrayerDay4580 : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Germany;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Germany;

        /// <inheritdoc />
        public override List<string> RegionCodes { get; set; } = new List<string>
        {
            "DE-BW", "DE-BE", "DE-HB", "DE-HH", "DE-HE",
            "DE-NI", "DE-NW", "DE-RP", "DE-SL", "DE-SH"
        };

        /// <inheritdoc />
        public override string Name { get; } = "Buß- und Bettag";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = -11;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_de_prayer_day_4580";

        /// <inheritdoc />
        public override int? Since { get; } = 1945;

        /// <inheritdoc />
        public override int? End { get; } = 1980;
    }
}