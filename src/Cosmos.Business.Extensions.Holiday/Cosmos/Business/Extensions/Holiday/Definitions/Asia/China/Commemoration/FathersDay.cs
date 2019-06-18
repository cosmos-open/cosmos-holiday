using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.China.Commemoration
{
    public class FathersDay : WeekOffsetVariableHolidayFunc
    {
        public override Country Country { get; } = Country.China;

        public override Country BelongsToCountry { get; } = Country.China;

        /// <summary>
        /// Father's day
        /// </summary>
        public override string Name { get; } = "父亲节";

        public override HolidayType HolidayType { get; set; } = HolidayType.Commemoration;

        public override int Month { get; } = 6;

        protected override int WeekAtMonth { get; } = 3;

        protected override DayOfWeek DayOfWeek { get; } = DayOfWeek.Sunday;

        public override string I18NIdentityCode { get; } = "i18n_holiday_cn_fuqinjie";

        /*
         * 父亲节（Father's Day），顾名思义是感恩父亲的节日。约始于二十世纪初，起源于美国，现已广泛流传于世界各地，节日日期因地域而存在差异。
         * 最广泛的日期在每年6月的第三个星期日，世界上有52个国家和地区是在这一天过父亲节。节日里有各种的庆祝方式，大部分都与赠送礼物、家族聚餐
         * 或活动有关。
         *
         * 中国大陆官方没有设立正式的父亲节。但内地民众习惯上使用6月第三个星期日当做父亲节；中国台湾父亲节是8月8日。
         * 中国台湾的父亲节订于每年的八月八日，又称为“八八节”。这是因为“八八”和爸爸相近，而且“八八”两字连缀起来，
         * 又好象一个 “父”字，所以父亲节特别被定于八月八日。
         *
         * 世界上的第一个父亲节，1910年诞生在美国，是由住在美国华盛顿州斯波坎(Spokane) 的布鲁斯多德夫人
         * (Mrs. Dodd，Sonora Louise Smart Dodd) 倡导的，多德夫人的母亲在生育第六个孩 子时，因难产而死，
         * 多德夫人的父亲威廉斯马特先生 (Mr. William Smart) 曾参加过南北战争，他在妻子过世后，独自一人在
         * 华盛顿州东部的一个乡下农场，承担起抚养、教育六个孩子的重任，多德夫人在家中排行老二，亦是家里唯
         * 一的女孩，女性的细心特质，让她更能体会父亲的辛劳，斯马特先生白天辛劳地工作，晚上回家还要照料家
         * 务与每一个孩子的生活，经过几十年的辛苦，儿女们终于长大成人，当子女们盼望能让斯马特先生好好安享
         * 晚年之际，斯马特先生却因多年的过度劳累于1909年辞世。
         *
         * 故使用 1910 作為起始年
         */

        public override int? Since { get; } = 1910;
    }
}