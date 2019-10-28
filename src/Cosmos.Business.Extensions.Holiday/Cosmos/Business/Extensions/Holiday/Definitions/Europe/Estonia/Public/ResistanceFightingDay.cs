using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Estonia.Public
{
    /// <summary>
    /// Resistance Fighting Day<br />
    /// et: vastupanuvõitluse päev
    /// </summary>
    public class ResistanceFightingDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Estonia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Estonia;

        /// <inheritdoc />
        public override string Name { get; } = "vastupanuvõitluse päev";

        /// <inheritdoc />
        public override int Month { get; set; } = 9;

        /// <inheritdoc />
        public override int Day { get; set; } = 22;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ee_resistance_fighting";
    }
}