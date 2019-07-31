using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Ireland.Public
{
    /// <summary>
    /// June Holiday
    /// </summary>
    public class JuneHoliday : WeekOffsetVariableHolidayFunc
    {

        /// <inheritdoc />
        public override Country Country { get; } = Country.Ireland;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Ireland;

        /// <inheritdoc />
        public override string Name { get; } = "Lá Saoire i mí an Mheithimh";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; } = 6;

        /// <inheritdoc />
        protected override int WeekAtMonth { get; } = 1;

        /// <inheritdoc />
        protected override DayOfWeek DayOfWeek { get; } = DayOfWeek.Monday;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ie_june_holiday";

        /// <inheritdoc />
        public override int? Since { get; } = 1973;
    }
}