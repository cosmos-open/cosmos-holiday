using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Bangladesh.Commemoration
{
    /// <summary>
    /// Krishna Janmashtami<br />
    /// bn: জন্মাষ্টমী
    /// </summary>
    public class KrishnaJanmashtami : BaseVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Bangladesh;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Bangladesh;

        /// <inheritdoc />
        public override string Name { get; } = "জন্মাষ্টমী";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bd_krishna_janmashtami";

        /// <inheritdoc />
        public override DailyAnswer ToDailyAnswer(int year)
        {
            var builder = DailyAnswerBuilder.Create(Name, HolidayType);

            switch (year)
            {
                case 2016:
                    builder.From(2016, 8, 25);
                    break;

                case 2017:
                    builder.From(2017, 8, 14);
                    break;

                case 2018:
                    builder.From(2018, 9, 2);
                    break;

                case 2020:
                    builder.From(2020, 8, 11);
                    break;

                default:
                    builder.From(year, 8, 24);
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