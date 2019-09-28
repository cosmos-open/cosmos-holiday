using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Bangladesh.Commemoration
{
    /// <summary>
    /// Buddha's Birthday<br />
    /// bn: বুদ্ধ পূর্ণিমা
    /// </summary>
    public class BuddhasBirthday : BaseVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Bangladesh;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Bangladesh;

        /// <inheritdoc />
        public override string Name { get; } = "বুদ্ধ পূর্ণিমা";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bd_buddha";

        /// <inheritdoc />
        public override DailyAnswer ToDailyAnswer(int year)
        {
            var builder = DailyAnswerBuilder.Create(Name, HolidayType);

            switch (year)
            {
                case 2016:
                    builder.From(2016, 5, 21);
                    break;

                case 2017:
                    builder.From(2017, 5, 10);
                    break;

                case 2018:
                    builder.From(2018, 4, 29);
                    break;

                case 2020:
                    builder.From(2020, 5, 7);
                    break;

                default:
                    builder.From(year, 5, 19);
                    break;
            }

            if (Since.HasValue)
                builder.Since(Since.Value);

            if (End.HasValue)
                builder.End(End.Value);

            if (TimeStepValue.HasValue)
                builder.Times(TimeStepValue.Value);

            builder.I18N(I18NIdentityCode);
            builder.Country(Country.ToCode(), GetRegionCodeList());

            return builder.Build(year);
        }
    }
}