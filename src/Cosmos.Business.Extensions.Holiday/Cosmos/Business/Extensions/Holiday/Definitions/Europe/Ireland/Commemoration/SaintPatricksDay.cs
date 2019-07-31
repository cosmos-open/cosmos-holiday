using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Ireland.Commemoration
{
    /// <summary>
    /// Saint Patrick's Day
    /// <br />
    /// 爱尔兰国庆节
    /// </summary>
    public class SaintPatricksDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Ireland;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Ireland;

        /// <inheritdoc />
        public override string Name { get; } = "Lá Fhéile Pádraig";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 3;

        /// <inheritdoc />
        public override int Day { get; set; } = 17;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ie_patrick";

        /// <inheritdoc />
        public override int? Since { get; } = 1903;
    }
}