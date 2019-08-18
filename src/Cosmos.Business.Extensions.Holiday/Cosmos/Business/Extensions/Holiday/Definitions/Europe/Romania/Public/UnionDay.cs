using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Romania.Public
{
    /// <summary>
    /// Union Day/Small Union
    /// </summary>
    public class UnionDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Romania;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Romania;

        /// <inheritdoc />
        public override string Name { get; } = "Unirea Principatelor Române/Mica Unire";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override int Month { get; set; } = 1;

        /// <inheritdoc />
        public override int Day { get; set; } = 24;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ro_small_union";
    }
}