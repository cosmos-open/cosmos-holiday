using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Curaçao.Religion
{
    /// <summary>
    /// Carnival Monday<br />
    ///  nl: Carnavalmaandag
    /// pap: Dialuna di Carnaval
    /// </summary>
    public class CarnivalMonday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Curaçao;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Netherlands;

        /// <inheritdoc />
        public override string Name { get; } = "Carnavalmaandag";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = -48;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cw_carnival_monday";
    }
}