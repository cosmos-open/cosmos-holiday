using System;

// ReSharper disable once CheckNamespace
namespace Cosmos.Business.Extensions.Holiday
{
    public static partial class HolidayInfoExtensions
    {
        public static HolidayInfo Clone(this HolidayInfo hi)
        {
            if (hi == null)
                throw new ArgumentNullException(nameof(hi));
            return new HolidayInfo(hi);
        }
    }
}