using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Germany.Commemoration
{
    /// <summary>
    /// Reformation Day
    /// </summary>
    public class ReformationDay2018After : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Germany;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Germany;

        /// <inheritdoc />
        public override List<string> RegionCodes { get; set; } = new List<string>
        {
            "DE-BB", "DE-MV", "DE-SN", "DE-ST", "DE-TH",
            "DE-HB", "DE-HH", "DE-NI", "DE-SH"
        };

        /// <inheritdoc />
        public override string Name { get; } = "Reformationstag";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 10;

        /// <inheritdoc />
        public override int Day { get; set; } = 31;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_de_reformation_day";

        /// <inheritdoc />
        public override int? Since { get; set; } = 2018;
    }
}