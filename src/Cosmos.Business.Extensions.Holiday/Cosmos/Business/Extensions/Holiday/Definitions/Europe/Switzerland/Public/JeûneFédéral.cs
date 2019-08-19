using System;
using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Switzerland.Public
{
    /// <summary>
    /// Jeûne Fédéral
    /// </summary>
    public class JeûneFédéral : WeekOffsetVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Switzerland;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Switzerland;

        /// <inheritdoc />
        public override List<string> RegionCodes { get; set; } = new List<string> {"CH-NE", "CH-VD"};

        /// <inheritdoc />
        public override string Name { get; } = "Jeûne Fédéral";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ch_jeune_federal";

        /// <inheritdoc />
        public override int Month { get; } = 9;

        /// <inheritdoc />
        protected override int WeekAtMonth { get; } = 3;

        /// <inheritdoc />
        protected override DayOfWeek DayOfWeek { get; } = DayOfWeek.Monday;
    }
}