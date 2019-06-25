using System;
using Cosmos.Business.Extensions.Holiday;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Business.Extensions.Weekends;

namespace Autofac
{
    /// <summary>
    /// Container extensions
    /// </summary>
    public static class ContainerExtensions
    {
        /// <summary>
        /// Register holiday
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="optionsAction"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static ContainerBuilder RegisterHoliday(this ContainerBuilder builder, Action<AutofacHolidayOptions> optionsAction = null)
        {
            if (builder == null)
                throw new ArgumentNullException(nameof(builder));

            var options = new AutofacHolidayOptions();

            //todo 读取配置，获取 Holiday 配置信息

            //todo 读取配置，获得运行时节日配置信息
            //扫描并生成到 options.RuntimeFixedHolidayFunc
            //读取并激活

            //To Activate Holiday options
            optionsAction?.Invoke(options);

            //To Activate Weekend options.
            builder.RegisterWeekendDefinitions(options);

            builder.RegisterType<HolidayGetter>().As<IHolidayGetter>().SingleInstance();
            builder.RegisterType(typeof(HolidayGetter<>)).As(typeof(IHolidayGetter<>)).SingleInstance();

            return builder;
        }

        // ReSharper disable once UnusedMethodReturnValue.Local
        private static ContainerBuilder RegisterWeekendDefinitions(this ContainerBuilder builder, AutofacHolidayOptions options)
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

            return builder;
        }
    }
}