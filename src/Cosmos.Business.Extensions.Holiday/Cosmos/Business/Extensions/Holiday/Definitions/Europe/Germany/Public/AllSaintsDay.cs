using System;
using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Germany.Public
{
    /// <summary>
    /// All Saints' Day
    /// </summary>
    public class AllSaintsDay : WeekOffsetVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Germany;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Germany;

        /// <inheritdoc />
        public override List<string> RegionCodes { get; set; } = new List<string> {"DE-BW", "DE-BY", "DE-NW", "DE-RP", "DE-SL"};

        /// <inheritdoc />
        public override string Name { get; } = "Allerheiligen";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; } = 11;

        /// <inheritdoc />
        protected override int WeekAtMonth { get; } = 1;

        /// <inheritdoc />
        protected override DayOfWeek DayOfWeek { get; } = DayOfWeek.Saturday;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_de_allsaintsday";
    }
}