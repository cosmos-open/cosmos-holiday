using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Armenia.School
{
    /// <summary>
    /// Knowledge, Literacy and Education Day
    /// </summary>
    public class KnowledgeLiteracyAndEducationDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Armenia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Armenia;

        /// <inheritdoc />
        public override string Name { get; } = "Գիտելիքի, գրի եւ դպրության օր";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.School;

        /// <inheritdoc />
        public override int Month { get; set; } = 9;

        /// <inheritdoc />
        public override int Day { get; set; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_am_knowledge";
    }
}