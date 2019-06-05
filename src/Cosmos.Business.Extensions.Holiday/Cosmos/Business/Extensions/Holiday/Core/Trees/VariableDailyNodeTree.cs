using System.Collections.Generic;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Core.Trees
{
    /// <summary>
    /// 用于 VariableHoliday 模式的节点树<br />
    /// 将根据 Year 动态地生成整年缓存（初始化时生成或第一次使用时缓存）
    /// </summary>
    public class VariableDailyNodeTree
    {
        private readonly CountryCode _code;

        //todo 需要重构这部分，按照年份做Key，然后再去查询这一年的 Month-Day 节日
        
        private readonly Dictionary<int, VariableDailyCache> _cachedMonthDictionary;
        private readonly List<VariableDailyNode> _variableDailyNodes;

        public VariableDailyNodeTree(CountryCode code)
        {
            _code = code;
            _variableDailyNodes = new List<VariableDailyNode>();
            _cachedMonthDictionary = new Dictionary<int, VariableDailyCache>
            {
                {1, new VariableDailyCache()},
                {2, new VariableDailyCache()},
                {3, new VariableDailyCache()},
                {4, new VariableDailyCache()},
                {5, new VariableDailyCache()},
                {6, new VariableDailyCache()},
                {7, new VariableDailyCache()},
                {8, new VariableDailyCache()},
                {9, new VariableDailyCache()},
                {10, new VariableDailyCache()},
                {11, new VariableDailyCache()},
                {12, new VariableDailyCache()}
            };
        }

        public CountryInfo GetCountryInfo() => CountryManager.GetCountryInfo(_code);
    }
}