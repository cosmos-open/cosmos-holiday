using System;

namespace Cosmos.Business.Extensions.Weekends
{
    [AttributeUsage(AttributeTargets.Class)]
    public class WeekendDefinitionIgnoreScanningAttribute : Attribute { }
}