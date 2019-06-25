using System;
using Cosmos.Business.Extensions.Holiday;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Weekends;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Service collection extensions
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Register holiday
        /// </summary>
        /// <param name="services"></param>
        /// <param name="optionsAction"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static IServiceCollection AddHoliday(this IServiceCollection services, Action<MSDIHolidayOptions> optionsAction = null)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            var options = new MSDIHolidayOptions();

            //todo 读取配置，获取 Holiday 配置信息

            //todo 读取配置，获得运行时节日配置信息
            //扫描并生成到 options.RuntimeFixedHolidayFunc
            //读取并激活

            //To Activate Holiday options
            optionsAction?.Invoke(options);

            //To Activate Weekend options.
            services.RegisterWeekendDefinitions(options);

            services.AddSingleton<IHolidayGetter, HolidayGetter>();
            services.AddSingleton(typeof(IHolidayGetter<>), typeof(HolidayGetter<>));

            return services;
        }

        // ReSharper disable once UnusedMethodReturnValue.Local
        private static IServiceCollection RegisterWeekendDefinitions(this IServiceCollection services, MSDIHolidayOptions options)
        {
            var weekendRegister = WeekendDefinitionRegister.Create();
            if (options.WeekendIncludeExtendDefinitions)
            {
                weekendRegister.IncludeExtendDefinitions();
            }

            if (!string.IsNullOrWhiteSpace(options.WeekendUnlinkedAssembliesPattern))
            {
                weekendRegister.IncludeExtendDefinitions();
                weekendRegister.UnlinkedAssembliesPattern(options.WeekendUnlinkedAssembliesPattern);
            }

            weekendRegister.Scan().Register(options.BizWeekendDefinitions).Done();

            return services;
        }
    }
}