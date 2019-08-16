using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Norway.Religion
{
    /// <summary>
    /// St. Stephen's Day
    /// </summary>
    public class StStephensDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Norway;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Norway;

        /// <inheritdoc />
        public override string Name { get; } = "Andre juledag";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override int Month { get; set; } = 12;

        /// <inheritdoc />
        public override int Day { get; set; } = 26;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_no_stephen";
    }
}