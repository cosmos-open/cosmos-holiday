using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Portugal.Commemoration
{
    /// <summary>
    /// Solemnity of Mary, Mother of God
    /// </summary>
    // ReSharper disable once InconsistentNaming
    public class SolemnityOfMary_MotherOfGod : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Portugal;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Portugal;

        /// <inheritdoc />
        public override string Name { get; } = "Solenidade de Santa Maria, Mãe de Deus";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 1;

        /// <inheritdoc />
        public override int Day { get; set; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_pt_mother_of_god";
    }
}