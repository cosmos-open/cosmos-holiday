using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Belarus.Public
{
    /// <summary>
    /// October Revolution Day
    /// </summary>
    public class OctoberRevolutionDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Belarus;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Belarus;

        /// <inheritdoc />
        public override string Name { get; } = "Дзень Кастрычніцкай рэвалюцыі";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 11;

        /// <inheritdoc />
        public override int Day { get; set; } = 17;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_by_october_revolution";
    }
}