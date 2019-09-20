using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Burundi.Commemoration
{
    /// <summary>
    /// Ntaryamira Day<br />
    /// fr: Jour de Ntaryamira
    /// </summary>
    public class NtaryamiraDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Burundi;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Burundi;

        /// <inheritdoc />
        public override string Name { get; } = "Jour de Ntaryamira";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 4;

        /// <inheritdoc />
        public override int Day { get; set; } = 6;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bi_ntaryamira";
    }
}