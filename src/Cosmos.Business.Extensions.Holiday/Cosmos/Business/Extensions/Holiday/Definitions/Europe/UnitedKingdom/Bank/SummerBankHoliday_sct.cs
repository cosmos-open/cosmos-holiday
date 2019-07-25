using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.UnitedKingdom.Bank
{
    /// <summary>
    /// Summer Bank Holiday for GB-SCT
    /// </summary>
    public class SummerBankHolidaySct : WeekOffsetVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.UnitedKingdom;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.UnitedKingdom;

        /// <inheritdoc />
        public override string RegionCode { get; } = "GB-SCT";

        /// <inheritdoc />
        public override string Name { get; } = "Early May Bank Holiday";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Bank;

        /// <inheritdoc />
        public override int Month { get; } = 8;

        /// <inheritdoc />
        protected override int WeekAtMonth { get; } = 1;

        /// <inheritdoc />
        protected override DayOfWeek DayOfWeek { get; } = DayOfWeek.Monday;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_gb_summer_bank_sct";

        /// <inheritdoc />
        public override int? Since { get; } = 1971;
    }
}