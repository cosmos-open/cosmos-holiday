using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Andorra.Commemoration
{
    /// <summary>
    /// Escaldes–Engordany Annual Festival
    /// </summary>
    public class EscaldesEngordanyAnnualFestival : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Andorra;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Andorra;

        /// <inheritdoc />
        public override string Name { get; } = "Escaldes-Engordany";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override (int Month, int Day)? FromDate { get; set; } = (7, 25);

        /// <inheritdoc />
        public override (int Month, int Day)? ToDate { get; set; } = (7, 26);

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ad_escaldes_engordany";
    }
}