using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Armenia.Public
{
    /// <summary>
    /// Mother Language Day
    /// </summary>
    public class MotherLanguageDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Armenia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Armenia;

        /// <inheritdoc />
        public override string Name { get; } = "Մայրենի լեզվի օր";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 2;

        /// <inheritdoc />
        public override int Day { get; set; } = 21;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_am_mother_language";
    }
}