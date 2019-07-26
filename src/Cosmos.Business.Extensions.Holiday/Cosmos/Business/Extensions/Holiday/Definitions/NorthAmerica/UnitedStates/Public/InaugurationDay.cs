using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.UnitedStates.Public
{
    /// <summary>
    /// Inauguration Day
    /// </summary>
    public class InaugurationDay : BaseVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.UnitedStates;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.UnitedStates;

        /// <inheritdoc />
        public override List<string> RegionCodes { get; set; } = new List<string> {"US-DC", "US-LA", "US-MD", "US-VA"};

        /// <inheritdoc />
        public override string Name { get; } = "Inauguration Day";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_us_inauguration";

        /// <inheritdoc />
        public override DailyAnswer ToDailyAnswer(int year)
        {
            if ((year - 1) % 4 == 0)
            {
                DailyAnswerBuilder builder;
                if (year >= 1937)
                {
                    builder = DailyAnswerBuilder.Create(Name, HolidayType).From(year, 1, 20);
                }
                else
                {
                    builder = DailyAnswerBuilder.Create(Name, HolidayType).From(year, 3, 4);
                }

                return builder
                    .Country(Country.ToCode(), GetRegionCodeList())
                    .I18N(I18NIdentityCode)
                    .Build(year);
            }

            return null;
        }
    }
}