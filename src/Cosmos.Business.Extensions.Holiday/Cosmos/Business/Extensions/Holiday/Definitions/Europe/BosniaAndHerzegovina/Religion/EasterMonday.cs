using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.BosniaAndHerzegovina.Religion
{
    /// <summary>
    /// Easter Monday<br />
    /// bs: Uskrsni ponedjeljak
    /// sr: Католички Васкрсни понедељак
    /// hr: Uskršnji ponedjeljak
    /// </summary>
    public class EasterMonday : CatholicVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.BosniaAndHerzegovina;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.BosniaAndHerzegovina;

        /// <summary>
        /// Easter Monday
        /// </summary>
        public override string Name { get; } = "Uskrsni ponedjeljak";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        protected override int OffsetEasterSunday { get; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ba_easter_monday";

        /// <inheritdoc />
        public override int? Since { get; } = 1642;
    }
}