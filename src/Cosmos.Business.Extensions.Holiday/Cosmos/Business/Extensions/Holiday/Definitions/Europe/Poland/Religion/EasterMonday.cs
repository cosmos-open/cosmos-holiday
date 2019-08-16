using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Poland.Religion
{
    /// <summary>
    /// Easter Monday
    /// </summary>
    public class EasterMonday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Poland;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Poland;

        /// <inheritdoc />
        public override string Name { get; } = "Drugi Dzień Wielkanocy";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_pl_easter_monday";

        /// <inheritdoc />
        public override int? Since { get; } = 1642;
    }
}