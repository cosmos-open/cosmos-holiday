using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Spain.Religion
{
    /// <summary>
    /// St. Stephen's Day
    /// </summary>
    public class StStephensDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Spain;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Spain;

        /// <inheritdoc />
        public override List<string> RegionCodes { get; set; } = new List<string> {"ES-CT", "ES-IB"};

        /// <inheritdoc />
        public override string Name { get; } = "Sant Esteve";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override int Month { get; set; } = 12;

        /// <inheritdoc />
        public override int Day { get; set; } = 26;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_es_stephen";
    }
}