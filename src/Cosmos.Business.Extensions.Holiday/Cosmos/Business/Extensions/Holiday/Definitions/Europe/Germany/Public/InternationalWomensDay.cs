using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Germany.Public
{
    /// <summary>
    /// International Women's Day
    /// </summary>
    public class InternationalWomensDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Germany;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Germany;

        /// <inheritdoc />
        public override string RegionCode { get; } = "DE-BE";

        /// <inheritdoc />
        public override string Name { get; } = "Internationaler Frauentag";

        /// <inheritdoc />
        public override int Month { get; set; } = 3;

        /// <inheritdoc />
        public override int Day { get; set; } = 8;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_de_women";

        /// <inheritdoc />
        public override int? Since { get; } = 2019;
    }
}