namespace Cosmos.Business.Extensions.Holiday.Core
{
    public class HolidayGetter<THolidayProvider> : IHolidayGetter<THolidayProvider>
        where THolidayProvider : class, IHolidayDictionary { }
}