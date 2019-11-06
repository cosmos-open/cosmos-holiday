using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Uganda.Commemoration
{
    /// <summary>
    /// Archbishop Janan Luwum Day
    /// </summary>
    public class ArchbishopJananLuwumDay : BaseFixedHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Uganda;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Uganda;

        /// <inheritdoc />
        public override string Name { get; } = "Archbishop Janan Luwum Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override int Month { get; set; } = 2;

        /// <inheritdoc />
        public override int Day { get; set; } = 16;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_ug_janan_luwum";
    }
}