using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Bahamas.Public
{
    /// <summary>
    /// National Heroes' Day
    /// </summary>
    public class NationalHeroesDay : WeekShiftVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Bahamas;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Bahamas;

        /// <inheritdoc />
        public override string Name { get; } = "National Heroes' Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get;  } = 10;

        /// <inheritdoc />
        public override int Day { get; } = 12;

        /// <inheritdoc />
        protected override int SaturdayShift { get; } = 2;

        /// <inheritdoc />
        protected override int SundayShift { get; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bs_national_heroes";
    }
}