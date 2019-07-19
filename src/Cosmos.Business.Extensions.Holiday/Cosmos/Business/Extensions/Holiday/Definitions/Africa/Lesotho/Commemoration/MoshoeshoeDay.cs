using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Lesotho.Commemoration
{
    /// <summary>
    /// Moshoeshoe Day
    /// </summary>
    public class MoshoeshoeDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Lesotho;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Lesotho;

        /// <inheritdoc />
        public override string Name { get; } = "Moshoeshoe Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 3;

        /// <inheritdoc />
        public override int Day { get; set; } = 11;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ls_moshoeshoe_day";
    }
}