using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Macedonia.Public
{
    /// <summary>
    /// Revolution Day
    /// </summary>
    public class RevolutionDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Macedonia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Macedonia;

        /// <inheritdoc />
        public override string Name { get; } = "Ден на востанието, Den na vostanieto";

        /// <inheritdoc />
        public override int Month { get; set; } = 10;

        /// <inheritdoc />
        public override int Day { get; set; } = 11;

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_mk_revolution";
    }
}