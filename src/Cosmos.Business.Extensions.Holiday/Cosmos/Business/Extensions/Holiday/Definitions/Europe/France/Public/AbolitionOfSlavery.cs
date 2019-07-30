using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.France.Public
{
    /// <summary>
    /// Abolition of Slavery
    /// </summary>
    public class AbolitionOfSlavery : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.France;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.France;

        /// <inheritdoc />
        public override List<string> RegionCodes { get; set; } = new List<string> {"FR-GP", "FR-MF", "FR-BL"};

        /// <inheritdoc />
        public override string Name { get; } = "Abolition de l'esclavage";

        /// <inheritdoc />
        public override int Month { get; set; } = 5;

        /// <inheritdoc />
        public override int Day { get; set; } = 22;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_fr_abolition_of_slavery";
    }
}