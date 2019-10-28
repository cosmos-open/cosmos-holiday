using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Date;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Africa.Ethiopia.Religion
{
    /// <summary>
    /// Finding of the True Cross<br />
    /// am: ብርሐነ-መስቀል
    /// </summary>
    public class FindingOfTHeTrueCross : BaseVariableHolidayFunc
    {

        /// <inheritdoc />
        public override Country Country { get; } = Country.Ethiopia;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Ethiopia;

        /// <inheritdoc />
        public override string Name { get; } = "ብርሐነ-መስቀል";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Religion;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; }

        /// <inheritdoc />
        public override DailyAnswer ToDailyAnswer(int year)
        {
            var date = DateTimeFactory.Create(year, 9, 27);

            if (date.IsLeapYear())
                return null;

            var builder = DailyAnswerBuilder.Create(Name, HolidayType).From(date);

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