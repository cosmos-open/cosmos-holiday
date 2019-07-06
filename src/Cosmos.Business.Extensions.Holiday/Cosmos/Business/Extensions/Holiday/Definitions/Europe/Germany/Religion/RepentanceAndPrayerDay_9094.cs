using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Germany.Religion
{
    /// <summary>
    /// Repentance and Prayer Day
    /// </summary>
    public class RepentanceAndPrayerDay9094 : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Germany;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Germany;

        /// <inheritdoc />
        public override string Name { get; } = "Buß- und Bettag";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = -11;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_de_prayer_day_9094";

        /// <inheritdoc />
        public override int? Since { get; } = 1990;

        /// <inheritdoc />
        public override int? End { get; } = 1994;
    }
}