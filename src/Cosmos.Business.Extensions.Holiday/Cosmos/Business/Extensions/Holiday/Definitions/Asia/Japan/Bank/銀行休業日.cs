using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Japan.Bank
{
    /// <summary>
    /// 銀行休業日
    /// </summary>
    public class 銀行休業日: BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Japan;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Japan;

        /// <inheritdoc />
        public override string Name { get; } = "銀行休業日";

        /// <inheritdoc />
        public override (int Month, int Day)? FromDate { get; set; } = (1, 2);

        /// <inheritdoc />
        public override (int Month, int Day)? ToDate { get; set; } = (1, 3);

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Bank;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_jp_bank0203";
    }
}