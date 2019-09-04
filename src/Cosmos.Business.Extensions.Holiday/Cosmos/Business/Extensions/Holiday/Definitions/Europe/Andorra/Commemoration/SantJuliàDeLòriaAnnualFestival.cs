using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Andorra.Commemoration
{
    /// <summary>
    /// Sant Julià de Lòria Annual Festival
    /// </summary>
    public class SantJuliàDeLòriaAnnualFestival : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Andorra;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Andorra;

        /// <inheritdoc />
        public override string Name { get; } = "Sant Julià de Lòria";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override (int Month, int Day)? FromDate { get; set; } = (7, 27);

        /// <inheritdoc />
        public override (int Month, int Day)? ToDate { get; set; } = (7, 30);

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ad_st_julia_de_loria";
    }
}