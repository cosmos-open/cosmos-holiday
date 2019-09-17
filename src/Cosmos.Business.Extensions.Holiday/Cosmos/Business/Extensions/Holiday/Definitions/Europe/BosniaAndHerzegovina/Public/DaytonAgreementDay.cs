using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.BosniaAndHerzegovina.Public
{
    /// <summary>
    ///  Dayton Agreement Day<br />
    /// bs: Dan uspostave Opšteg okvirnog sporazuma za mir u Bosni i Hercegovini
    /// </summary>
    public class DaytonAgreementDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.BosniaAndHerzegovina;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.BosniaAndHerzegovina;

        /// <inheritdoc />
        public override string RegionCode { get; } = "BA-SRP";

        /// <inheritdoc />
        public override string Name { get; } = "Dan uspostave Opšteg okvirnog sporazuma za mir u Bosni i Hercegovini";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 11;

        /// <inheritdoc />
        public override int Day { get; set; } = 21;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ba_dayton_agreement";
    }
}