namespace Cosmos.Business.Extensions.Holiday.Core
{
    /// <summary>
    /// Interface of variable holiday func
    /// </summary>
    public interface IVariableHolidayFunc : IHolidayFunc
    {

        #region Scinde and end

        /// <summary>
        /// 表示节日从何年开始生效（包含该年）
        /// </summary>
        int? Since { get; }

        /// <summary>
        /// 表示节日至何年起无效（包含该年
        /// </summary>
        int? End { get; }

        /// <summary>
        /// 计算届数时每届间隔的时间
        /// </summary>
        int? TimeStepValue { get; }

        #endregion

        #region To DailyAnswer

        /// <summary>
        /// Convert to <see cref="DailyAnswer"/>
        /// <br />
        /// 转换为 DailyAnswer
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        DailyAnswer ToDailyAnswer(int year);

        #endregion

    }
}