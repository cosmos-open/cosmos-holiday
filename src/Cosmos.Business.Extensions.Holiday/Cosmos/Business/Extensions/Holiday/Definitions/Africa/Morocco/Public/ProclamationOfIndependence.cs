using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Morocco.Public
{
    /// <summary>
    /// Proclamation of Independence
    /// </summary>
    public class ProclamationOfIndependence : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Morocco;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Morocco;

        /// <inheritdoc />
        public override string Name { get; } = "Takdim watikat al-istiqlal";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 1;

        /// <inheritdoc />
        public override int Day { get; set; } = 11;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ma_proclamation_of_independence";

        /// <inheritdoc />
        public override int? Since { get; set; } = 1956;
    }
}