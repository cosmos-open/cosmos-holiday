using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Lesotho.Religion
{
    /// <summary>
    /// Ascension Day
    /// </summary>
    public class AscensionDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Lesotho;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Lesotho;

        /// <inheritdoc />
        public override string Name { get; } = "Ascension Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 5;

        /// <inheritdoc />
        public override int Day { get; set; } = 9;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ls_ascension_day";
    }
}