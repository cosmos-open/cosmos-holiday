using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.Bangladesh.Commemoration
{
    /// <summary>
    /// Durga Puja<br />
    /// bn: দুর্গা পূজা
    /// </summary>
    public class DurgaPuja : BaseVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Bangladesh;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Bangladesh;

        /// <inheritdoc />
        public override string Name { get; } = "দুর্গা পূজা";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_bd_durga_puja";

        /// <inheritdoc />
        public override DailyAnswer ToDailyAnswer(int year)
        {
            var builder = DailyAnswerBuilder.Create(Name, HolidayType);

            switch (year)
            {
                case 2016:
                    builder.From(2016, 10, 11);
                    break;

                case 2017:
                    builder.From(2017, 9, 30);
                    break;

                case 2018:
                    builder.From(2018, 10, 19);
                    break;

                case 2020:
                    builder.From(2020, 10, 25);
                    break;

                default:
                    builder.From(year, 10, 8);
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