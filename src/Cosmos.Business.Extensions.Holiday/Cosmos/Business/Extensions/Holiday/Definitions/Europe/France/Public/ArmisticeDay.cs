using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.France.Public
{
    /// <summary>
    /// Armistice Day
    /// </summary>
    public class ArmisticeDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.France;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.France;

        /// <inheritdoc />
        public override string Name { get; } = "Armistice de 1918";

        /// <inheritdoc />
        public override int Month { get; set; } = 11;

        /// <inheritdoc />
        public override int Day { get; set; } = 11;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_fr_armistice";
    }
}