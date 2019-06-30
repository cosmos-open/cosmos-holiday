using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Oceania.Australia.Public
{
    /// <summary>
    /// Anzac Day for AU-ACT, AU-NT, AU-SA and AU-WA
    /// </summary>
    public class AnzacDayActNtSaWa : ShiftVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Australia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Australia;

        /// <inheritdoc />
        public override List<string> RegionCodes { get; set; } = new List<string> {"AU-ACT", "AU-NT", "AU-SA", "AU-WA"};

        /// <summary>
        /// National Day
        /// </summary>
        public override string Name { get; } = "Anzac Day";

        /// <summary>
        /// Type of holiday
        /// </summary>
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; } = 4;

        /// <inheritdoc />
        public override int Day { get; } = 25;

        /// <inheritdoc />
        protected override int SaturdayShift { get; } = 2;

        /// <inheritdoc />
        protected override int SundayShift { get; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_au_anzacday_act";
    }
}