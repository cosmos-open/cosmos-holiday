using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Turkey.Public
{
    /// <summary>
    /// Democracy Day
    /// </summary>
    public class DemocracyDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Turkey;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Turkey;

        /// <inheritdoc />
        public override string Name { get; } = "Demokrasi Bayramı";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 7;

        /// <inheritdoc />
        public override int Day { get; set; } = 15;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_tr_democracy";
    }
}