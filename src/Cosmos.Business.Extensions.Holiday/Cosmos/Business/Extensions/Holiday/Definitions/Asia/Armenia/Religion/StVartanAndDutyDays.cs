using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Armenia.Religion
{
    /// <summary>
    /// St. Vartan the good work and the duty days
    /// </summary>
    public class StVartanAndDutyDays : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Armenia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Armenia;

        /// <inheritdoc />
        public override string Name { get; } = "Սուրբ Վարդանանց տոն՝ բարի գործի եւ ազգային տուրքի օր";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = -52;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_am_vartan_duty";
    }
}