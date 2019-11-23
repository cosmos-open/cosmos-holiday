using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Martinique.Public
{
    /// <summary>
    /// Abolition of Slavery<br />
    /// fr: Abolition de l’esclavage
    /// </summary>
    public class AbolitionOfSlavery : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Martinique;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Martinique;

        /// <inheritdoc />
        public override string Name { get; } = "Abolition de l’esclavage";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 5;

        /// <inheritdoc />
        public override int Day { get; set; } = 22;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_mq_slavery";
    }
}