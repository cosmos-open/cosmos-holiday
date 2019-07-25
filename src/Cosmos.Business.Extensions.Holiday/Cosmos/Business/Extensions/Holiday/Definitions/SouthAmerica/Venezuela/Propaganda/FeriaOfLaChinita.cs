using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.SouthAmerica.Venezuela.Propaganda
{
    /// <summary>
    /// Feria of La Chinita
    /// </summary>
    public class FeriaOfLaChinita : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Venezuela;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Venezuela;

        /// <inheritdoc />
        public override string Name { get; } = "Feria de la Chinita";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Propaganda;

        /// <inheritdoc />
        public override (int Month, int Day)? FromDate { get; set; } = (11 ,17);

        /// <inheritdoc />
        public override (int Month, int Day)? ToDate { get; set; } = (11, 19);

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ve_feria_of_la_chinita";
    }
}