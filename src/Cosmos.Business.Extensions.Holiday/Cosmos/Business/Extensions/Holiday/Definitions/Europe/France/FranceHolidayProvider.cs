using System.Collections.Generic;
using System.Linq;
using Cosmos.Abstractions;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Holiday.Core.Helpers;
using Cosmos.Business.Extensions.Holiday.Core.Internals;
using Cosmos.Business.Extensions.Holiday.Definitions;
using Cosmos.I18N.Countries;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    using Definitions.Europe.France.Commemoration;
    using Definitions.Europe.France.Public;
    using Definitions.Europe.France.Religion;
    using Definitions.Europe.France.Tradition;

    /// <summary>
    /// Germany holiday provider
    /// </summary>
    public class FranceHolidayProvider : BaseDefinitionRegister, IBizHolidayDefinition
    {
        private static IEnumerable<string> RegionCache { get; } = Enumerable.Empty<string>();

        /// <summary>
        /// Country or region
        /// </summary>
        public override Country Country { get; } = Country.France;

        /// <summary>
        /// Belongs to country
        /// </summary>
        public override Country BelongsToCountry { get; } = Country.France;

        /// <summary>
        /// Include regions
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> IncludeRegions() => RegionCache;

        /// <summary>
        /// Does this provider include special type of regions?
        /// </summary>
        /// <param name="regionCode"></param>
        /// <returns></returns>
        public override bool DoesIncludeRegion(string regionCode)
        {
            if (string.IsNullOrWhiteSpace(regionCode))
                return false;

            regionCode = CountryHelper.FixRegionCode(Country.France, regionCode);

            switch (regionCode)
            {
                case "FR-YT":
                    return InternalSingleInstanceServiceLocator.HolidayProviderManager.ContainsRegion(CountryCode.YT);
                case "FR-MQ":
                    return InternalSingleInstanceServiceLocator.HolidayProviderManager.ContainsRegion(CountryCode.MQ);
                case "FR-GP":
                    return InternalSingleInstanceServiceLocator.HolidayProviderManager.ContainsRegion(CountryCode.GP);
                case "FR-GF":
                    return InternalSingleInstanceServiceLocator.HolidayProviderManager.ContainsRegion(CountryCode.GF);
                case "FR-RE":
                    return InternalSingleInstanceServiceLocator.HolidayProviderManager.ContainsRegion(CountryCode.RE);
                case "FR-MF":
                    return InternalSingleInstanceServiceLocator.HolidayProviderManager.ContainsRegion(CountryCode.MF);
                case "FR-TF":
                    return InternalSingleInstanceServiceLocator.HolidayProviderManager.ContainsRegion(CountryCode.TF);
                case "FR-BL":
                    return InternalSingleInstanceServiceLocator.HolidayProviderManager.ContainsRegion(CountryCode.BL);
                default:
                    return base.DoesIncludeRegion(regionCode);
            }
        }

        /// <summary>
        /// Geta all fixed holiday funcs
        /// </summary>
        protected override List<IFixedHolidayFunc> AllFixedHolidayFuncs { get; } = FrFixedHolidayFuncs;

        private static List<IFixedHolidayFunc> FrFixedHolidayFuncs = new List<IFixedHolidayFunc>
        {
            new NewYearsDay(), //1-1
            new LabourDay(), //5-1
            new VictoryInEuropeDay(), //5-8
            new AbolitionOfSlavery(), //5-22
            new AbolitionOfSlaveryMq(), //5-27
            new BastilleDay(), //7-14
            new AssumptionDay(), //8-15
            new ArmisticeDay(), //11-11
            new ChristmasDay(), //12-25
            new StStephensDay(), //12-26
        };

        /// <summary>
        /// Gets all variable holiday funcs
        /// </summary>
        protected override List<IVariableHolidayFunc> AllVariableHolidayFuncs { get; } = FrVariableHolidayFuncs;

        private static List<IVariableHolidayFunc> FrVariableHolidayFuncs = new List<IVariableHolidayFunc>
        {
            new AllSaintsDay(), //11月第一个周六
            new GoodFriday(),
            new EasterMonday(),
            new AscensionDay(),
            new WhitMonday(),
        };

        /// <summary>
        /// Get sources
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<string> GetSources()
        {
            return new[]
            {
                "https://en.wikipedia.org/wiki/Public_holidays_in_France",
                "https://en.wikipedia.org/wiki/ISO_3166-2:FR",
            };
        }
    }
}