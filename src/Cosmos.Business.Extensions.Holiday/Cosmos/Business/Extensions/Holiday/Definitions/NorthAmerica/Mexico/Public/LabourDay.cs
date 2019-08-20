using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Mexico.Public
{
    /// <summary>
    /// Labour Day
    /// </summary>
    public class LabourDay : WeekShiftVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Mexico;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Mexico;

        /// <inheritdoc />
        public override string Name { get; } = "Día del Trabajo";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; } = 5;

        /// <inheritdoc />
        public override int Day { get; } = 1;

        /// <inheritdoc />
        protected override int SaturdayShift { get; } = -1;

        /// <inheritdoc />
        protected override int SundayShift { get; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_mx_labour";
    }
}