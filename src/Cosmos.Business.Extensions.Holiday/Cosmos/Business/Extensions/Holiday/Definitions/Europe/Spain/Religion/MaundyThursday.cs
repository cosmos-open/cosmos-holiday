using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Spain.Religion
{
    /// <summary>
    /// Maundy Thursday
    /// </summary>
    public class MaundyThursday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Spain;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Spain;

        /// <inheritdoc />
        public override List<string> RegionCodes { get; set; } = new List<string>
        {
            "ES-AN", "ES-AR", "ES-CE", "ES-ML", "ES-CL", "ES-CM", "ES-IC", "ES-EX",
            "ES-GA", "ES-IB", "ES-LO", "ES-M", "ES-MU", "ES-NA", "ES-O", "ES-PV",
            "ES-CB"
        };

        /// <inheritdoc />
        public override string Name { get; } = "Jueves Santo";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = -3;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_es_maundy_thursday";
    }
}