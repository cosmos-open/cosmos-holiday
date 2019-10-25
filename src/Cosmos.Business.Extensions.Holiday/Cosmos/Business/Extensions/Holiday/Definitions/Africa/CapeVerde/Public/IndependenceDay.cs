using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.CapeVerde.Public
{
    /// <summary>
    /// Independence Day<br />
    /// pt: Dia da Independência
    /// </summary>
    public class IndependenceDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.CapeVerde;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.CapeVerde;

        /// <inheritdoc />
        public override string Name { get; } = "Dia da Independência";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 7;

        /// <inheritdoc />
        public override int Day { get; set; } = 5;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cv_independence";
    }
}