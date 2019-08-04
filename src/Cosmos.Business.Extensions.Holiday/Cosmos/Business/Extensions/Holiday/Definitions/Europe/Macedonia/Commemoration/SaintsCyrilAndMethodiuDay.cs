using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Macedonia.Commemoration
{
    /// <summary>
    /// Saints Cyril and Methodius Day
    /// </summary>
    public class SaintsCyrilAndMethodiuDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Macedonia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Macedonia;

        /// <inheritdoc />
        public override string Name { get; } = "Св. Кирил и Методиј, Ден на сèсловенските просветители";

        /// <inheritdoc />
        public override int Month { get; set; } = 5;

        /// <inheritdoc />
        public override int Day { get; set; } = 24;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_mk_cyril_and_methodiu";
    }
}