using System;
using System.Linq;
using System.Collections.Generic;
using Cosmos.Date;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Core
{
    /// <summary>
    /// Daily answer builder
    /// </summary>
    public class DailyAnswerBuilder
    {
        private readonly DailyAnswer _answer;

        private DailyAnswerBuilder() { }

        private DailyAnswerBuilder(string name, HolidayType type)
        {
            _answer = new DailyAnswer {Name = name, Type = type};
        }

        /// <summary>
        /// Create a new instance for <see cref="DailyAnswerBuilder"/>.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static DailyAnswerBuilder Create(string name, HolidayType type)
        {
            return new DailyAnswerBuilder(name, type);
        }

        /// <summary>
        /// Sets i18n info
        /// </summary>
        /// <param name="identityCode"></param>
        /// <returns></returns>
        public DailyAnswerBuilder I18N(string identityCode)
        {
            _answer.I18NIdentityCode = identityCode;
            return this;
        }

        /// <summary>
        /// Sets holiday from...
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public DailyAnswerBuilder From(int year, int month, int day)
        {
            _answer.FromDate = new DateInfo(year, month, day);
            _answer.ToDate = _answer.FromDate;
            return this;
        }

        /// <summary>
        /// Sets holiday from...
        /// </summary>
        /// <param name="year"></param>
        /// <param name="tuple"></param>
        /// <returns></returns>
        public DailyAnswerBuilder From(int year, (int Month, int Day) tuple)
        {
            _answer.FromDate = new DateInfo(year, tuple.Month, tuple.Day);
            _answer.ToDate = _answer.FromDate;
            return this;
        }

        /// <summary>
        /// Sets holiday from...
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public DailyAnswerBuilder From(DateTime date)
        {
            _answer.FromDate = date;
            _answer.ToDate = _answer.FromDate;
            return this;
        }

        /// <summary>
        /// Sets holiday to...
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public DailyAnswerBuilder To(int year, int month, int day)
        {
            _answer.ToDate = new DateInfo(year, month, day);
            return this;
        }

        /// <summary>
        /// Sets holiday to...
        /// </summary>
        /// <param name="year"></param>
        /// <param name="tuple"></param>
        /// <returns></returns>
        public DailyAnswerBuilder To(int year, (int Month, int Day) tuple)
        {
            _answer.ToDate = new DateInfo(year, tuple.Month, tuple.Day);
            return this;
        }

        /// <summary>
        /// Sets holiday to...
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public DailyAnswerBuilder To(DateTime date)
        {
            _answer.ToDate = date;
            return this;
        }

        /// <summary>
        /// Sets holiday to...
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public DailyAnswerBuilder To(int length)
        {
            _answer.ToDate = _answer.ToDate.AddDays(length);
            return this;
        }

        /// <summary>
        /// Sets when the holiday launches from...
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public DailyAnswerBuilder Since(int year)
        {
            if (_answer._times == null)
                _answer._times = new DailyAnswer.DailyTimesAnswer();
            _answer._times.SinceYear = year;
            return this;
        }

        /// <summary>
        /// Sets when the holiday end...
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public DailyAnswerBuilder End(int year)
        {
            if (_answer._times == null)
                _answer._times = new DailyAnswer.DailyTimesAnswer();
            _answer._times.EndYear = year;
            return this;
        }

        /// <summary>
        /// Sets times
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public DailyAnswerBuilder Times(int value)
        {
            if (_answer._times == null)
                _answer._times = new DailyAnswer.DailyTimesAnswer();
            _answer._times.StepValue = value;
            return this;
        }

        /// <summary>
        /// Sets country info and region info
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCodeList"></param>
        /// <returns></returns>
        public DailyAnswerBuilder Country(CountryCode code, List<string> regionCodeList = null)
        {
            _answer.CountryCode = code;
            if (regionCodeList != null)
            {
                var temp = _answer.RegionCodeList;
                temp.AddRange(regionCodeList);
                _answer.RegionCodeList = temp.Distinct().ToList();
            }

            return this;
        }

        /// <summary>
        /// Sets region info.
        /// </summary>
        /// <param name="regionCodeList"></param>
        /// <returns></returns>
        public DailyAnswerBuilder Regions(List<string> regionCodeList)
        {
            if (regionCodeList != null)
            {
                var temp = _answer.RegionCodeList;
                temp.AddRange(regionCodeList);
                _answer.RegionCodeList = temp.Distinct().ToList();
            }

            return this;
        }

        /// <summary>
        /// Build, and return an instance of <see cref="DailyAnswer"/>.
        /// </summary>
        /// <param name="targetYear"></param>
        /// <returns></returns>
        public DailyAnswer Build(int targetYear)
        {
            var times = _answer.Times;

            if (times == null)
                return _answer;

            if (!_answer._times.SinceYear.HasValue || !_answer._times.StepValue.HasValue)
                return _answer;

            var exceptYear = _answer._times.SinceYear.Value + _answer._times.StepValue.Value * times.Value;

            if (exceptYear == targetYear)
                return _answer;

            return null;
        }
    }
}