using System.Collections.Generic;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Helpers;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Oceania.Guam.Public;

    /// <summary>
    /// American Samoa Holiday Provider
    /// </summary>
    public class GuamHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.Guam;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.UnitedStates;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions()
        {
            return new[] {CountryHelper.GetRegionCode(Country, BelongsToCountry)};
        }

        /// <inheritdoc />
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = GuFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> GuFixedHolidayFuncs = new List<IFixedHolidayFunc>();

        /// <inheritdoc />
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = GuVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> GuVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new GuamHistoryAndChamorroHeritageDay(),//4-1st-monday
            new LiberationDay(),//7-21
            new OurLadyOfCamarinDay(),//12-8
        };

        /// <inheritdoc />
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_the_United_States#Guam",
                "https://en.wikipedia.org/wiki/Public_holidays_in_Guam",
                "https://www.guamtax.com/help/holidays.html",
                "http://www.guamcourts.org/CompilerofLaws/GCA/01gca/1gc010.PDF",
                "http://www.guamcourts.org/Holidays-and-Hours/JOG-Holidays-and-Hours.html"
            };
        }
    }
}