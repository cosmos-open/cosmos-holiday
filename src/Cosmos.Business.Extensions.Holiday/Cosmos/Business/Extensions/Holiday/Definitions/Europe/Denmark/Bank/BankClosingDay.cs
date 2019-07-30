using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Denmark.Bank
{
    /// <summary>
    /// Bank closing day
    /// </summary>
    public class BankClosingDay : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Denmark;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Denmark;

        /// <inheritdoc />
        public override string Name { get; } = "Banklukkedag";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Bank;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = 5 + 5 * 7;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_dk_bank_closing_day";
    }
}