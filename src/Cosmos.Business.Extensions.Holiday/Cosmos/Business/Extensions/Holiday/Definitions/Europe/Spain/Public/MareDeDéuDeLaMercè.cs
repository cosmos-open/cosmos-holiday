using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Date;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Europe.Spain.Public
{
    /// <summary>
    /// Mare de Déu de la Mercè
    /// </summary>
    public class MareDeDéuDeLaMercè : BaseVariableHolidayFunc
    {
        /// <inheritdoc />
        public override Country Country { get; } = Country.Spain;

        /// <inheritdoc />
        public override Country BelongsToCountry { get; } = Country.Spain;

        /// <inheritdoc />
        public override string RegionCode { get; } = "ES-CT";

        /// <inheritdoc />
        public override string Name { get; } = "Mare de Déu de la Mercè";

        /// <inheritdoc />
        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        /// <inheritdoc />
        public override string I18NIdentityCode { get; } = "i18n_holiday_es_mare_de_deu_de_la_merce";

        /// <inheritdoc />
        public override DailyAnswer ToDailyAnswer(int year)
        {
            var calculationDay = DateTimeFactory.Create(year, 9, 24);
            if (calculationDay.DayOfWeek == DayOfWeek.Sunday)
                calculationDay = DateTimeFactory.FindNextDay(calculationDay, DayOfWeek.Monday);

            var builder = DailyAnswerBuilder
                .Create(Name, HolidayType)
                .From(calculationDay);

            if (Since.HasValue)
                builder.Since(Since.Value);

            if (End.HasValue)
                builder.End(End.Value);

            if (TimeStepValue.HasValue)
                builder.Times(TimeStepValue.Value);

            builder.Country(Country.ToCode(), GetRegionCodeList());

            return builder.I18N(I18NIdentityCode).Build(year);
        }
    }
}