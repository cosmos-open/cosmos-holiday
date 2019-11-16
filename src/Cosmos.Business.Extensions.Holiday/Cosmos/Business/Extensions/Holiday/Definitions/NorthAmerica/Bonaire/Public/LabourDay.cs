using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Date;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Bonaire.Public
{
    /// <summary>
    /// Labour Day
    /// </summary>
    public class LabourDay : WeekShiftVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Bonaire;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Netherlands;

        /// <inheritdoc />
        public override string Name { get; } = "Labour Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bm_labour";

        /// <inheritdoc />
        public override int Month { get; } = 5;

        /// <inheritdoc />
        public override int Day { get; } = 1;

        /// <inheritdoc />
        protected override int SundayShift { get; } = 1;
    }
}