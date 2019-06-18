using System;
using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.NorthAmerica.UnitedStates.Public
{
    public class FathersDay : WeekOffsetVariableHolidayFunc
    {
        public override Country Country { get; } = Country.UnitedStates;

        public override Country BelongsToCountry { get; } = Country.UnitedStates;

        /// <summary>
        /// Father's day
        /// </summary>
        public override string Name { get; } = "Father's Day";

        public override HolidayType HolidayType { get; set; } = HolidayType.Public;

        public override int Month { get; } = 6;

        protected override int WeekAtMonth { get; } = 3;

        protected override DayOfWeek DayOfWeek { get; } = DayOfWeek.Sunday;

        public override string I18NIdentityCode { get; } = "i18n_holiday_us_fathersday";

        /*
         * 世界上的第一个父亲节，1910年诞生在美国，是由住在美国华盛顿州斯波坎(Spokane) 的布鲁斯多德夫人
         * (Mrs. Dodd，Sonora Louise Smart Dodd) 倡导的，多德夫人的母亲在生育第六个孩 子时，因难产而死，
         * 多德夫人的父亲威廉斯马特先生 (Mr. William Smart) 曾参加过南北战争，他在妻子过世后，独自一人在
         * 华盛顿州东部的一个乡下农场，承担起抚养、教育六个孩子的重任，多德夫人在家中排行老二，亦是家里唯
         * 一的女孩，女性的细心特质，让她更能体会父亲的辛劳，斯马特先生白天辛劳地工作，晚上回家还要照料家
         * 务与每一个孩子的生活，经过几十年的辛苦，儿女们终于长大成人，当子女们盼望能让斯马特先生好好安享
         * 晚年之际，斯马特先生却因多年的过度劳累于1909年辞世。
         */
        
        public override int? Since { get; } = 1910;
    }
}