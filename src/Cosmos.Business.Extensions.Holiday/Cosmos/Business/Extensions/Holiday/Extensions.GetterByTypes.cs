using System.Collections.Generic;
using System.Linq;

namespace Cosmos.Business.Extensions.Holiday
{
    /// <summary>
    /// Extensions for Holiday Getter
    /// </summary>
    public static class HolidayGetterByTypesExtensions
    {
        /// <summary>
        /// Filter as...
        /// </summary>
        /// <param name="holidayInfos"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static IEnumerable<IHolidayInfo> Filter(this IEnumerable<IHolidayInfo> holidayInfos, HolidayType type)
        {
            return holidayInfos?.Where(x => x.Type == type);
        }

        /// <summary>
        /// Filter as Public holiday
        /// </summary>
        /// <param name="holidayInfos"></param>
        /// <returns></returns>
        public static IEnumerable<IHolidayInfo> PublicFilter(this IEnumerable<IHolidayInfo> holidayInfos)
        {
            return holidayInfos.Filter(HolidayType.Public);
        }

        /// <summary>
        /// Filter as Commemoration holiday
        /// </summary>
        /// <param name="holidayInfos"></param>
        /// <returns></returns>
        public static IEnumerable<IHolidayInfo> CommemorationFilter(this IEnumerable<IHolidayInfo> holidayInfos)
        {
            return holidayInfos.Filter(HolidayType.Commemoration);
        }

        /// <summary>
        /// Filter as Tradition holiday
        /// </summary>
        /// <param name="holidayInfos"></param>
        /// <returns></returns>
        public static IEnumerable<IHolidayInfo> TraditionFilter(this IEnumerable<IHolidayInfo> holidayInfos)
        {
            return holidayInfos.Filter(HolidayType.Tradition);
        }

        /// <summary>
        /// Filter as Lunar holiday
        /// </summary>
        /// <param name="holidayInfos"></param>
        /// <returns></returns>
        public static IEnumerable<IHolidayInfo> LunarFilter(this IEnumerable<IHolidayInfo> holidayInfos)
        {
            return holidayInfos.Filter(HolidayType.Lunar);
        }

        /// <summary>
        /// Filter as Religion holiday
        /// </summary>
        /// <param name="holidayInfos"></param>
        /// <returns></returns>
        public static IEnumerable<IHolidayInfo> ReligionFilter(this IEnumerable<IHolidayInfo> holidayInfos)
        {
            return holidayInfos.Filter(HolidayType.Religion);
        }

        /// <summary>
        /// Filter as School holiday
        /// </summary>
        /// <param name="holidayInfos"></param>
        /// <returns></returns>
        public static IEnumerable<IHolidayInfo> SchoolFilter(this IEnumerable<IHolidayInfo> holidayInfos)
        {
            return holidayInfos.Filter(HolidayType.School);
        }

        /// <summary>
        /// Filter as Bank holiday
        /// </summary>
        /// <param name="holidayInfos"></param>
        /// <returns></returns>
        public static IEnumerable<IHolidayInfo> BankFilter(this IEnumerable<IHolidayInfo> holidayInfos)
        {
            return holidayInfos.Filter(HolidayType.Bank);
        }

        /// <summary>
        /// Filter as Propaganda holiday
        /// </summary>
        /// <param name="holidayInfos"></param>
        /// <returns></returns>
        public static IEnumerable<IHolidayInfo> PropagandaFilter(this IEnumerable<IHolidayInfo> holidayInfos)
        {
            return holidayInfos.Filter(HolidayType.Propaganda);
        }


    }
}