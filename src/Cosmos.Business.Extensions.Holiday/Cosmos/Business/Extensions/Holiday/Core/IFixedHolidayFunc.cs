using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Core
{
    public interface IFixedHolidayFunc
    {
        /// <summary>
        /// 标记赌赢的国家或地区
        /// </summary>
        Country Country { get; }
        
        /// <summary>
        /// 标记该国家或地区的所属国家
        /// </summary>
        Country BelongsToCountry { get; }

        /// <summary>
        /// 固定节日的名称
        /// </summary>
        string Name { get; }

        /// <summary>
        /// 固定节日类型
        /// </summary>
        HolidayType HolidayType { get; }

        /// <summary>
        /// 固定节日的月份
        /// </summary>
        int Month { get; }

        /// <summary>
        /// 固定节日的日份
        /// </summary>
        int Day { get; }

        /// <summary>
        /// 固定节日的起始日期，优先级高于 Month 和 Day
        /// </summary>
        (int Month, int Day)? FromDate { get; set; }

        /// <summary>
        /// 固定节日的截止日期，优先级高于 Month 和 Day
        /// </summary>
        (int Month, int Day)? ToDate { get; set; }

        /// <summary>
        /// 用于判断指定月份是否命中本节日
        /// </summary>
        /// <param name="month"></param>
        /// <returns></returns>
        bool MatchDate(int month);

        /// <summary>
        /// 用于判断指定月份和日份是否命中本节日
        /// </summary>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        bool MatchDate(int month, int day);

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

        /// <summary>
        /// I18N 识别码
        /// </summary>
        string I18NIdentityCode { get; }

        /// <summary>
        /// 转换为 DailyAnswer
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        DailyAnswer ToDailyAnswer(int year);
    }
}