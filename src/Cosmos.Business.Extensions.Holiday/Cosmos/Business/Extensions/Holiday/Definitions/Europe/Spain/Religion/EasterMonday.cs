using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Spain.Religion
{
    /// <summary>
    /// Easter Monday
    /// </summary>
    public class EasterMonday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Spain;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Spain;

        /// <inheritdoc />
        public override List<string> RegionCodes { get; set; } = new List<string> {"ES-CT", "ES-IB", "ES-NA", "ES-PV", "ES-VC"};

        /// <inheritdoc />
        public override string Name { get; } = "Ostermontag";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_es_easter_monday";

        /// <inheritdoc />
        public override int? Since { get; } = 1642;
    }
}