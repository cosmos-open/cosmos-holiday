using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.CapeVerde.Public
{
    /// <summary>
    /// Children's Day<br />
    /// pt: Dia das Crianças
    /// </summary>
    public class ChildrenDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.CapeVerde;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.CapeVerde;

        /// <inheritdoc />
        public override string Name { get; } = "Dia das Crianças";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 6;

        /// <inheritdoc />
        public override int Day { get; set; } = 1;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_cv_children";
    }
}