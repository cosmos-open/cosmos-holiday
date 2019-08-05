using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Monaco.Commemoration
{
    /// <summary>
    /// Saint Devota's Day
    /// </summary>
    public class SaintDevotasDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Monaco;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Monaco;

        /// <inheritdoc />
        public override string Name { get; } = "La Sainte Dévotey";

        /// <inheritdoc />
        public override int Month { get; set; } = 1;

        /// <inheritdoc />
        public override int Day { get; set; } = 27;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_mc_devota";
    }
}