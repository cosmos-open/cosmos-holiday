using System;
using System.Linq;
using Cosmos.I18N.Countries;
using Microsoft.Extensions.DependencyInjection;
using Shouldly;
using Xunit;

namespace Cosmos.Business.Extensions.Holiday.Tests
{
    public class UsageTests
    {
        private readonly IServiceProvider _provider;

        public UsageTests()
        {
            var services = new ServiceCollection();
            services.AddHoliday(o => o.UseChina().UseHongKong());
            _provider = services.BuildServiceProvider();
        }

        [Fact]
        public void HolidayGetterTest()
        {
            using (var scope = _provider.CreateScope())
            {
                var getter = scope.ServiceProvider.GetService<IHolidayGetter>();
                getter.ShouldNotBeNull("getter != null");

                var getter2 = scope.ServiceProvider.GetService<IHolidayGetter<ChinaHolidayProvider>>();
                getter2.ShouldNotBeNull("getter<China> != null");
            }
        }

        [Fact]
        public void NationDayTest()
        {
            using (var scope = _provider.CreateScope())
            {
                var getter1 = scope.ServiceProvider.GetService<IHolidayGetter>();
                var getter2 = scope.ServiceProvider.GetService<IHolidayGetter<ChinaHolidayProvider>>();

                var holiday1 = getter1.GetHolidays(CountryCode.CN, 2019, 10, 1).ToList();
                var holiday2 = getter2.GetHolidays(2019, 10, 1).ToList();
                var holiday3 = getter2.GetHolidays(1948, 10, 1).ToList();
                var holiday4 = getter2.GetHolidays(1949, 10, 1).ToList();
                var holiday5 = getter1.GetHolidays(CountryCode.CN, "HK", 2019, 10, 1).ToList();
                var holiday6 = getter1.GetHolidays(CountryCode.CN, "CN-HK", 2019, 10, 1).ToList();
                var holiday7 = getter2.GetHolidays("HK", 2019, 10, 1).ToList();
                var holiday8 = getter2.GetHolidays("CN-HK", 2019, 10, 1).ToList();
                var holiday9 = getter2.GetHolidays("cn-hk", 2019, 10, 1).ToList();

                holiday1.ShouldNotBeNull();
                holiday1.Count.ShouldBe(2);
                holiday2.Count.ShouldBe(2);
                holiday3.Count.ShouldBe(0);
                holiday4.Count.ShouldBe(2);
                holiday5.Count.ShouldBe(1);
                holiday6.Count.ShouldBe(1);
                holiday7.Count.ShouldBe(1);
                holiday8.Count.ShouldBe(1);
                holiday9.Count.ShouldBe(1);

                // ReSharper disable once InconsistentNaming
                var _10 = holiday1.First();
                _10.I18NIdentityCode.ShouldBe("i18n_holiday_cn_china10");

                // ReSharper disable once InconsistentNaming
                var _10_2 = holiday9.First();
                _10_2.I18NIdentityCode.ShouldBe("i18n_holiday_hk_guoqing");
            }
        }

        [Fact]
        public void DoubleSevenDayTest()
        {
            using (var scope = _provider.CreateScope())
            {
                var getter1 = scope.ServiceProvider.GetService<IHolidayGetter>();
                var getter2 = scope.ServiceProvider.GetService<IHolidayGetter<ChinaHolidayProvider>>();

                var holiday1 = getter1.GetHolidays(CountryCode.CN, 2019, 8, 7).ToList();
                var holiday2 = getter2.GetHolidays(2019, 8, 7).ToList();
                var holiday3 = getter1.GetHolidays(CountryCode.CN, "HK", 2019, 8, 7).ToList();
                var holiday4 = getter2.GetHolidays("CN-hk", 2019, 8, 7).ToList();

                holiday1.ShouldNotBeNull();
                holiday1.Count.ShouldBe(1);
                holiday2.Count.ShouldBe(1);
                holiday3.Count.ShouldBe(0);
                holiday4.Count.ShouldBe(0);

                // ReSharper disable once InconsistentNaming
                var _77 = holiday1.First();
                _77.I18NIdentityCode.ShouldBe("i18n_holiday_cn_qixi");
            }
        }
    }
}