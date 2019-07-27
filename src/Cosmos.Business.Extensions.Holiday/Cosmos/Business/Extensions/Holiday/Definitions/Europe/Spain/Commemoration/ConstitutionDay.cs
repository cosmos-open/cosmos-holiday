using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Spain.Commemoration
{
    /// <summary>
    /// Constitution Day
    /// </summary>
    public class ConstitutionDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Spain;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Spain;

        /// <inheritdoc />
        public override string Name { get; } = "Día de la Constitución";

        /// <inheritdoc />
        public override int Month { get; set; } = 12;

        /// <inheritdoc />
        public override int Day { get; set; } = 6;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_es_constitution";
    }
}