using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Albania.Tradition
{
    /// <summary>
    /// Nowruz
    /// </summary>
    public class Nowruz : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Albania;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Albania;

        /// <inheritdoc />
        public override string Name { get; } = "Dita e Sulltan Nevruzit";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Tradition;

        /// <inheritdoc />
        public override int Month { get; set; } = 3;

        /// <inheritdoc />
        public override int Day { get; set; } = 22;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_al_nowruz";
    }
}