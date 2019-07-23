using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Botswana.Commemoration
{
    /// <summary>
    /// Sir Seretse Khama Day
    /// </summary>
    public class SirSeretseKhamaDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Botswana;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Botswana;

        /// <inheritdoc />
        public override string Name { get; } = "Sir Seretse Khama Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 7;

        /// <inheritdoc />
        public override int Day { get; set; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bw_sir_seretse_khama";
    }
}