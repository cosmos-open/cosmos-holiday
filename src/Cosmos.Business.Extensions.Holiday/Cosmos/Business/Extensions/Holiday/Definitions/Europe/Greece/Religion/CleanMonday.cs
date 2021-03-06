using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Greece.Religion
{
    /// <summary>
    /// Easter Monday
    /// </summary>
    public class CleanMonday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Greece;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Greece;

        /// <inheritdoc />
        public override string Name { get; } = "Καθαρά Δευτέρα";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = -48;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_gr_clean_monday";
    }
}