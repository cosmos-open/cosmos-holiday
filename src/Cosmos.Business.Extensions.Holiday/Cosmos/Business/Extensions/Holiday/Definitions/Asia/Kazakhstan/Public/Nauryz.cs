using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Kazakhstan.Public
{
    /// <summary>
    /// Nauryz - March 21th
    /// </summary>
    public class Nauryz : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Kazakhstan;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Kazakhstan;

        /// <inheritdoc />
        public override string Name { get; } = "Наурыз мейрамы";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override (int Month, int Day)? FromDate { get; set; } = (3, 21);

        /// <inheritdoc />
        public override (int Month, int Day)? ToDate { get; set; } = (3, 23);

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_kz_nauryz";
    }
}