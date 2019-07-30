using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.France.Religion
{
    /// <summary>
    /// Good Friday
    /// </summary>
    public class GoodFriday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.France;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.France;

        /// <inheritdoc />
        public override List<string> RegionCodes { get; set; }=new List<string> { "FR-A", "FR-57" };

        /// <inheritdoc />
        public override string Name { get; } = "Vendredi saint";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = -2;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_fr_good_friday";
    }
}