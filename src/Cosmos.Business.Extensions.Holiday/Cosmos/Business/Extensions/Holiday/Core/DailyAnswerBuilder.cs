using System;
using Cosmos.Date;

namespace Cosmos.Business.Extensions.Holiday.Core
{
    public class DailyAnswerBuilder
    {
        private readonly DailyAnswer _answer;

        private DailyAnswerBuilder() { }

        private DailyAnswerBuilder(string name)
        {
            _answer = new DailyAnswer {Name = name};
        }

        public static DailyAnswerBuilder Create(string name) => new DailyAnswerBuilder(name);

        public DailyAnswerBuilder I18N(string identityCode)
        {
            _answer.I18NIdentityCode = identityCode;
            return this;
        }

        public DailyAnswerBuilder From(int year, int month, int day)
        {
            _answer.FromDate = new DateInfo(year, month, day);
            _answer.ToDate = _answer.FromDate;
            return this;
        }

        public DailyAnswerBuilder From(DateTime date)
        {
            _answer.FromDate = date;
            _answer.ToDate = _answer.FromDate;
            return this;
        }

        public DailyAnswerBuilder To(int year, int month, int day)
        {
            _answer.ToDate = new DateInfo(year, month, day);
            return this;
        }

        public DailyAnswerBuilder To(DateTime date)
        {
            _answer.ToDate = date;
            return this;
        }

        public DailyAnswerBuilder Since(int year)
        {
            if (_answer._times == null)
                _answer._times = new DailyAnswer.DailyTimesAnswer();
            _answer._times.SinceYear = year;
            return this;
        }

        public DailyAnswerBuilder End(int year)
        {
            if (_answer._times == null)
                _answer._times = new DailyAnswer.DailyTimesAnswer();
            _answer._times.EndYear = year;
            return this;
        }

        public DailyAnswerBuilder Times(int value)
        {
            if (_answer._times == null)
                _answer._times = new DailyAnswer.DailyTimesAnswer();
            _answer._times.StepValue = value;
            return this;
        }

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