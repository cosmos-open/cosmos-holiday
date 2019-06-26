using Cosmos.Business.Extensions.Holiday.Core.Trees;

namespace Cosmos.Business.Extensions.Holiday.Core
{
    /// <summary>
    /// Holiday manager factory
    /// </summary>
    public static class HolidayManagerFactory
    {
        /// <summary>
        /// Create
        /// </summary>
        /// <returns></returns>
        public static IHolidayManager Create()
        {
            return Create(new DailyNodeTree(), new VariableDailyNodeTree());
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="dailyNodeTree"></param>
        /// <param name="variableDailyNodeTree"></param>
        /// <returns></returns>
        public static IHolidayManager Create(DailyNodeTree dailyNodeTree, VariableDailyNodeTree variableDailyNodeTree)
        {
            return new HolidayManager(dailyNodeTree, variableDailyNodeTree);
        }
    }
}