using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Core.Trees
{
    /// <summary>
    /// 用于 VariableHoliday 模式的节点树<br />
    /// 将根据 Year 动态地生成整年缓存（初始化时生成或第一次使用时缓存）
    /// </summary>
    public class VariableDailyNodeTree
    {
        private readonly ConcurrentDictionary<CountryCode, VariableDailyNode> _variableDailyNodes;

        /// <summary>
        /// Create a new instance of <see cref="VariableDailyNodeTree"/>
        /// </summary>
        public VariableDailyNodeTree()
        {
            _variableDailyNodes = new ConcurrentDictionary<CountryCode, VariableDailyNode>();
        }

        #region Get DailyNode

        /// <summary>
        /// Get an instance of <see cref="VariableDailyNode"/>
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public VariableDailyNode GetDailyNode(CountryCode code)
        {
            return _variableDailyNodes.TryGetValue(code, out var node) ? node : EmptyVariableDailyNode.Create(code);
        }

        /// <summary>
        /// Get an instance of <see cref="VariableDailyNode"/>
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public VariableDailyNode GetDailyNode(Country country)
        {
            return GetDailyNode(country.ToCode());
        }

        #endregion

        #region Get VariableHolidayFunc readonly collection

        /// <summary>
        /// Get a readonly list of <see cref="IVariableHolidayFunc"/>.
        /// </summary>
        /// <returns></returns>
        public IReadOnlyList<IVariableHolidayFunc> Get()
        {
            return _variableDailyNodes.Values.SelectMany(node => node.GetFuncs()).ToList().AsReadOnly();
        }

        /// <summary>
        /// Get a readonly list of <see cref="IVariableHolidayFunc"/>.
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public IReadOnlyList<IVariableHolidayFunc> Get(int year)
        {
            return _variableDailyNodes.Values.SelectMany(node => node.GetFuncs(year)).ToList().AsReadOnly();
        }

        /// <summary>
        /// Get a readonly list of <see cref="IVariableHolidayFunc"/>.
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public IReadOnlyList<IVariableHolidayFunc> Get(CountryCode code)
        {
            return GetDailyNode(code).GetFuncs(code);
        }

        /// <summary>
        /// Get a readonly list of <see cref="IVariableHolidayFunc"/>.
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public IReadOnlyList<IVariableHolidayFunc> Get(Country country)
        {
            return GetDailyNode(country).GetFuncs(country);
        }

        /// <summary>
        /// Get a readonly list of <see cref="IVariableHolidayFunc"/>.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <returns></returns>
        public IReadOnlyList<IVariableHolidayFunc> Get(CountryCode code, string regionCode)
        {
            return GetDailyNode(code).GetFuncs(code, regionCode);
        }

        /// <summary>
        /// Get a readonly list of <see cref="IVariableHolidayFunc"/>.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <returns></returns>
        public IReadOnlyList<IVariableHolidayFunc> Get(Country country, string regionCode)
        {
            return GetDailyNode(country).GetFuncs(country, regionCode);
        }

        /// <summary>
        /// Get a readonly list of <see cref="IVariableHolidayFunc"/>.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public IReadOnlyList<IVariableHolidayFunc> Get(CountryCode code, int year)
        {
            return GetDailyNode(code).GetFuncs(code, year);
        }

        /// <summary>
        /// Get a readonly list of <see cref="IVariableHolidayFunc"/>.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public IReadOnlyList<IVariableHolidayFunc> Get(Country country, int year)
        {
            return GetDailyNode(country).GetFuncs(country, year);
        }

        /// <summary>
        /// Get a readonly list of <see cref="IVariableHolidayFunc"/>.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public IReadOnlyList<IVariableHolidayFunc> Get(CountryCode code, string regionCode, int year)
        {
            return GetDailyNode(code).GetFuncs(code, regionCode, year);
        }

        /// <summary>
        /// Get a readonly list of <see cref="IVariableHolidayFunc"/>.
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public IReadOnlyList<IVariableHolidayFunc> Get(Country country, string regionCode, int year)
        {
            return GetDailyNode(country).GetFuncs(country, regionCode, year);
        }

        #endregion

        #region Get DailyAnswer collection

        /// <summary>
        /// Get a collection of <see cref="DailyAnswer"/> by special year and country code
        /// </summary>
        /// <param name="code"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> GetDailyAnswers(CountryCode code, int year)
        {
            foreach (var fun in Get(code, year))
                yield return fun.ToDailyAnswer(year);
        }

        /// <summary>
        /// Get a collection of <see cref="DailyAnswer"/> by special year and country
        /// </summary>
        /// <param name="country"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> GetDailyAnswers(Country country, int year)
        {
            foreach (var fun in Get(country, year))
                yield return fun.ToDailyAnswer(year);
        }

        /// <summary>
        /// Get a collection of <see cref="DailyAnswer"/> by special year, country code and region code
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> GetDailyAnswers(CountryCode code, string regionCode, int year)
        {
            foreach (var fun in Get(code, regionCode, year))
                yield return fun.ToDailyAnswer(year);
        }

        /// <summary>
        /// Get a collection of <see cref="DailyAnswer"/> by special year, country and region code
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public IEnumerable<DailyAnswer> GetDailyAnswers(Country country, string regionCode, int year)
        {
            foreach (var fun in Get(country, regionCode, year))
                yield return fun.ToDailyAnswer(year);
        }

        #endregion

        #region Add / AddRange

        /// <summary>
        /// Add
        /// </summary>
        /// <param name="func"></param>
        public void Add(IVariableHolidayFunc func)
        {
            if (func == null)
                return;
            var countryCode = func.BelongsToCountry.ToCode();
            if (_variableDailyNodes.TryGetValue(countryCode, out var node))
            {
                node.Add(func);
            }
            else
            {
                node = new VariableDailyNode(func.BelongsToCountry);
                node.Add(func);
                _variableDailyNodes.TryAdd(countryCode, node);
            }
        }

        /// <summary>
        /// Add
        /// </summary>
        /// <param name="funcFunc"></param>
        public void Add(Func<IVariableHolidayFunc> funcFunc)
        {
            Add(funcFunc?.Invoke());
        }

        /// <summary>
        /// AddRange
        /// </summary>
        /// <param name="funcs"></param>
        public void AddRange(IEnumerable<IVariableHolidayFunc> funcs)
        {
            if (funcs == null)
                return;
            foreach (var func in funcs)
                Add(func);
        }

        /// <summary>
        /// AddRange
        /// </summary>
        /// <param name="funcsFunc"></param>
        public void AddRange(Func<IEnumerable<IVariableHolidayFunc>> funcsFunc)
        {
            AddRange(funcsFunc?.Invoke());
        }

        #endregion

    }
}