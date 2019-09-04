using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Andorra.Commemoration
{
    /// <summary>
    /// Andorra La Vella Festival
    /// </summary>
    public class AndorraLaVellaFestival : WeekOffsetVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Andorra;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Andorra;

        /// <inheritdoc />
        public override string RegionCode { get; } = "AD-07";

        /// <inheritdoc />
        public override string Name { get; } = "Andorra La Vella Festival";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; } = 8;

        /// <inheritdoc />
        protected override int WeekAtMonth { get; } = 1;

        /// <inheritdoc />
        protected override DayOfWeek DayOfWeek { get; } = DayOfWeek.Saturday;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ad_andorra_la_vella_festival";
    }
}