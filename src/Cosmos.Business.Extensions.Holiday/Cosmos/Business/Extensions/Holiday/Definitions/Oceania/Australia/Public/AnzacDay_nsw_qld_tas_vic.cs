using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Oceania.Australia.Public
{
    /// <summary>
    /// Anzac Day for AU-NSW, AU-QLD, AU-TAS and AU-VIC
    /// </summary>
    public class AnzacDayNswQldTasVic : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Australia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Australia;

        /// <inheritdoc />
        public override List<string> RegionCodes { get; set; } = new List<string> {"AU-NSW", "AU-QLD", "AU-TAS", "AU-VIC"};

        /// <summary>
        /// National Day
        /// </summary>
        public override string Name { get; } = "Anzac Day";

        /// <summary>
        /// Type of holiday
        /// </summary>
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 4;

        /// <inheritdoc />
        public override int Day { get; set; } = 25;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_au_anzacday";
    }
}