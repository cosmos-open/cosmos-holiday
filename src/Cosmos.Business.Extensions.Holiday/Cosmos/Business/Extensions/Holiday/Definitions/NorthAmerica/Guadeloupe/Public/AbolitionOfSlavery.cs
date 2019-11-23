using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Guadeloupe.Public
{
    /// <summary>
    /// Abolition of Slavery
    /// </summary>
    public class AbolitionOfSlavery : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Guadeloupe;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.France;

        /// <inheritdoc />
        public override string Name { get; } = "Abolition of Slavery";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 5;

        /// <inheritdoc />
        public override int Day { get; set; } = 27;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_gp_abolition_of_slavery";
    }
}