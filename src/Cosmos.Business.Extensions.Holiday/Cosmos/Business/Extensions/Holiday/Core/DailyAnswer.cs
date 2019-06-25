using System;
using System.Collections.Generic;
using System.Linq;
using Cosmos.Date;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Core
{
    /// <summary>
    /// Daily answer
    /// </summary>
    public class DailyAnswer
    {
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// I18N
        /// </summary>
        public string I18NIdentityCode { get; set; }

        /// <summary>
        /// Date from...
        /// </summary>
        public DateInfo FromDate { get; set; }

        /// <summary>
        /// Date to...
        /// </summary>
        public DateInfo ToDate { get; set; }

        /// <summary>
        /// Length of the holiday
        /// </summary>
        public int Length => (ToDate.ToDateTime() - FromDate.ToDateTime()).Days + 1;

        #region Times

        // ReSharper disable once InconsistentNaming
        internal DailyTimesAnswer _times;

        /// <summary>
        /// Times
        /// </summary>
        public int? Times => _times?.GetTimes(FromDate.Year);

        /// <summary>
        /// 用于计算是第几届的节日
        /// </summary>
        public class DailyTimesAnswer
        {
            /// <summary>
            /// Since...
            /// </summary>
            public int? SinceYear { get; set; }

            /// <summary>
            /// End...
            /// </summary>
            public int? EndYear { get; set; }

            /// <summary>
            /// Step value...
            /// </summary>
            public int? StepValue { get; set; }

            /// <summary>
            /// Gets times...
            /// </summary>
            /// <param name="year"></param>
            /// <returns></returns>
            public int? GetTimes(int year)
            {
                if (!SinceYear.HasValue || !StepValue.HasValue)
                    return null;

                if (SinceYear.Value > year)
                    return null;

                if (EndYear.HasValue && EndYear.Value < year)
                    return null;

                if (StepValue.Value <= 0)
                    return null;

                return (int) Math.Floor((double) (year - SinceYear.Value + 1) / StepValue.Value);
            }
        }

        #endregion

        #region Match Date

        /// <summary>
        /// Match year<br />
        /// 匹配年份
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public bool Match(int year)
        {
            return year >= FromDate.Year && year <= ToDate.Year;
        }

        /// <summary>
        /// Match year and onth.<br />
        /// 匹配年月
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <returns></returns>
        public bool Match(int year, int month)
        {
            if (!Match(year))
                return false;

            var fromDate = DateTimeFactory.Create(FromDate.Year, FromDate.Month, 1);
            var toDate = DateTimeFactory.Create(ToDate.Year, ToDate.Month, 1);
            var dt = DateTimeFactory.Create(year, month, 1);

            // ReSharper disable once ConvertIfStatementToReturnStatement
            if (dt < fromDate || dt > toDate)
                return false;

            return true;
        }

        /// <summary>
        /// Match date.<br />
        /// 匹配日期
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public bool Match(int year, int month, int day)
        {
            if (!Match(year))
                return false;

            var dt = DateTimeFactory.Create(year, month, day);

            // ReSharper disable once ConvertIfStatementToReturnStatement
            if (dt < FromDate.ToDateTime() || dt > ToDate.ToDateTime())
                return false;

            return true;
        }

        #endregion

        #region Country and region

        /// <summary>
        /// Country code
        /// </summary>
        public CountryCode CountryCode { get; set; }

        /// <summary>
        /// Region code list
        /// </summary>
        public List<string> RegionCodeList { get; set; } = new List<string>();

        /// <summary>
        /// Match
        /// </summary>
        /// <param name="regionCode"></param>
        /// <returns></returns>
        public bool Match(string regionCode)
        {
            return RegionCodeList.Contains(regionCode.ToUpper());
        }

        /// <summary>
        /// Match
        /// </summary>
        /// <param name="regionCodeList"></param>
        /// <returns></returns>
        public bool Match(IEnumerable<string> regionCodeList)
        {
            if (regionCodeList == null)
                return false;
            return regionCodeList.All(x => RegionCodeList.Contains(x.ToUpper()));
        }

        #endregion

    }
}