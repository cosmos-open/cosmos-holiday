using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Extensions;
using Cosmos.Date;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.Mexico.Public
{
    /// <summary>
    /// Inauguration Day
    /// </summary>
    public class InaugurationDay : BaseVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Mexico;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Mexico;

        /// <inheritdoc />
        public override string Name { get; } = "Transmisión del Poder Ejecutivo Federal";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_mx_inauguration";

        /// <inheritdoc />
        public override DailyAnswer ToDailyAnswer(int year)
        {
            if ((year - 2) % 6 == 0)
            {
                var date = DateTimeFactory.Create(year, 12, 1)
                    .Shift(saturday => saturday.AddDays(-1), sunday => sunday.AddDays(1));

                return DailyAnswerBuilder
                    .Create(Name, HolidayType)
                    .From(date)
                    .Country(Country.ToCode(), GetRegionCodeList())
                    .I18N(I18NIdentityCode)
                    .Build(year);
            }

            return null;
        }
    }
}