using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Core
{
    public abstract class BaseVariableHolidayFunc : IVariableHolidayFunc
    {
        public abstract Country Country { get; set; }

        public abstract Country BelongsToCountry { get; set; }
        
        public abstract string Name { get; }
        
        public abstract  HolidayType HolidayType { get; set; }
        
        public abstract string I18NIdentityCode { get; }

        public virtual int? Since { get; } = null;

        public virtual int? End { get; } = null;

        public virtual int? TimeStepValue { get; } = null;

        public abstract DailyAnswer ToDailyAnswer(int year);
    }
}