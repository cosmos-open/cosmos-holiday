using System.Collections.Generic;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Date;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday
{
    /// <summary>
    /// HolidayInfo
    /// </summary>
    public class HolidayInfo : DateInfo, IHolidayInfo
    {
        private readonly DailyAnswer _dailyAnswer;

        internal HolidayInfo(DailyAnswer answer) : base(answer.FromDate.Year, answer.FromDate.Month, answer.FromDate.Day)
        {
            _dailyAnswer = answer;
        }

        /// <summary>
        /// Name
        /// </summary>
        public string Name => _dailyAnswer.Name;

        /// <summary>
        /// Country code
        /// </summary>
        public CountryCode CountryCode => _dailyAnswer.CountryCode;

        /// <summary>
        /// Length
        /// </summary>
        public int Length => 1;

        /// <summary>
        /// Since...
        /// </summary>
        public int? LaunchYear => _dailyAnswer._times?.SinceYear;

        /// <summary>
        /// End...
        /// </summary>
        public int? EndYear => _dailyAnswer._times?.EndYear;

        /// <summary>
        /// I18N Identity Code
        /// </summary>
        public string I18NIdentityCode => _dailyAnswer.I18NIdentityCode;

        /// <summary>
        /// Clone
        /// </summary>
        /// <returns></returns>
        public HolidayInfo Clone()
        {
            return new HolidayInfo(_dailyAnswer);
        }

        /// <summary>
        /// Match date by year
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public bool Match(int year) => _dailyAnswer.Match(year);

        /// <summary>
        /// Match date by year and month.
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public bool Match(int year, int month) => _dailyAnswer.Match(year, month);

        /// <summary>
        /// Match date by year, month and day
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public bool Match(int year, int month, int day) => _dailyAnswer.Match(year, month, day);

        /// <summary>
        /// Match country
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public bool Match(Country country) => _dailyAnswer.CountryCode == country.ToCode();

        /// <summary>
        /// Match country
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public bool Match(CountryCode code) => _dailyAnswer.CountryCode == code;

        /// <summary>
        /// Match region
        /// </summary>
        /// <param name="regionCode"></param>
        /// <returns></returns>
        public bool Match(string regionCode) => _dailyAnswer.Match(regionCode);

        /// <summary>
        /// Match country and region
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCode"></param>
        /// <returns></returns>
        public bool Match(Country country, string regionCode) => Match(country) && Match(regionCode);

        /// <summary>
        /// Match country and region
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCode"></param>
        /// <returns></returns>
        public bool Match(CountryCode code, string regionCode) => Match(code) && Match(regionCode);

        /// <summary>
        /// Match regions
        /// </summary>
        /// <param name="regionCodeList"></param>
        /// <returns></returns>
        public bool Match(IEnumerable<string> regionCodeList) => _dailyAnswer.Match(regionCodeList);

        /// <summary>
        /// Match country and regions
        /// </summary>
        /// <param name="country"></param>
        /// <param name="regionCodeList"></param>
        /// <returns></returns>
        public bool Match(Country country, IEnumerable<string> regionCodeList) => Match(country) && Match(regionCodeList);

        /// <summary>
        /// Match country and regions
        /// </summary>
        /// <param name="code"></param>
        /// <param name="regionCodeList"></param>
        /// <returns></returns>
        public bool Match(CountryCode code, IEnumerable<string> regionCodeList) => Match(code) && Match(regionCodeList);
    }
}