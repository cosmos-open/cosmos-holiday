using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.BosniaAndHerzegovina.Tradition
{
    /// <summary>
    /// All Saints' Day<br />
    /// bs: Dita e të gjithë Shenjtorëve
    /// sr: Сви Свети
    /// hr: Dita e të gjithë Shenjtorëve
    /// </summary>
    public class AllSaintsDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.BosniaAndHerzegovina;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.BosniaAndHerzegovina;

        /// <inheritdoc />
        public override string Name { get; } = "Dita e të gjithë Shenjtorëve";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Tradition;

        /// <inheritdoc />
        public override int Month { get; set; } = 11;

        /// <inheritdoc />
        public override int Day { get; set; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ba_all_saints";
    }
}