using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Mexico.Commemoration
{
    /// <summary>
    /// Benito Juárez's birthday
    /// </summary>
    public class BenitoJuárezsBirthday : WeekOffsetVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Mexico;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Mexico;

        /// <inheritdoc />
        public override string Name { get; } = "Natalicio de Benito Juárez";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; } = 4;

        /// <inheritdoc />
        protected override int WeekAtMonth { get; } = 3;

        /// <inheritdoc />
        protected override DayOfWeek DayOfWeek { get; } = DayOfWeek.Monday;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_mx_benito_juarezs_birthday";
    }
}