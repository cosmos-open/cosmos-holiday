using Cosmos.Business.Extensions.Holiday.Core;

namespace Cosmos.Business.Extensions.Holiday
{
    public interface IHolidayGetter<THolidayProvider> : IHolidayGetter
        where THolidayProvider : class, IHolidayDictionaryProvider { }
}