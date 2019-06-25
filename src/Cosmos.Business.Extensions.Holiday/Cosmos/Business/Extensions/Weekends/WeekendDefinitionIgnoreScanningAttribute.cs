using System;

namespace Cosmos.Business.Extensions.Weekends
{
    /// <summary>
    /// Weekend definition ignore scanning attribute
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class WeekendDefinitionIgnoreScanningAttribute : Attribute { }
}