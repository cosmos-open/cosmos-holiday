using System.Collections.Generic;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Core
{
    /// <summary>
    /// Interface of holiday provider
    /// </summary>
    public interface IHolidayProvider
    {
        /// <summary>
        /// Country or region
        /// </summary>
        Country Country { get; }

        /// <summary>
        /// Belongs to country
        /// </summary>
        Country BelongsToCountry { get; }

        /// <summary>
        /// Include region...
        /// </summary>
        /// <returns></returns>
        IEnumerable<string> IncludeRegions();

        /// <summary>
        /// Does this provider include such region code.
        /// </summary>
        /// <param name="regionCode"></param>
        /// <returns></returns>
        bool DoesIncludeRegion(string regionCode);

        /// <summary>
        /// Fix RegionCode
        /// </summary>
        /// <param name="regionCode"></param>
        /// <returns></returns>
        string FixRegionCode(string regionCode);

        /// <summary>
        /// Register all type of holiday
        /// </summary>
        void RegisterAll();

        /// <summary>
        /// Register spacial type of holiday
        /// </summary>
        /// <param name="types"></param>
        void Register(params HolidayType[] types);
    }
}