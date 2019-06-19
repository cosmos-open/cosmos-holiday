using Cosmos.Business.Extensions.Holiday.Core;
using Cosmos.Date.Chinese;
using Cosmos.I18N.Countries;

namespace Cosmos.Business.Extensions.Holiday.Definitions.Asia.China.Tradition
{
    public class TombSweepingDay : BaseVariableHolidayFunc
    {
        public override Country Country { get; } = Country.China;

        public override Country BelongsToCountry { get; } = Country.China;

        /// <summary>
        /// Tomb-Sweeping Day
        /// </summary>
        public override string Name { get; } = "清明节";

        public override HolidayType HolidayType { get; set; } = HolidayType.Tradition;

        public override string I18NIdentityCode { get; } = "i18n_holiday_cn_qingmingjie";

        public override DailyAnswer ToDailyAnswer(int year)
        {
            var date = ChineseDateInfo.Of(year, 4, 1);
            var date15 = date.AddDays(-15);
            while (true)
            {
                if (date15.GetSolarTerm() == "春分")
                    break;
                date = date.Tomorrow();
                date15 = date15.Tomorrow();
            }

            return DailyAnswerBuilder.Create(Name).From(date.ToDateTime()).I18N(I18NIdentityCode).Build(year);
        }

        /*
         * 公历4月5日前后，春分后的地15天
         * 
         * 清明节，又称踏青节、行清节、三月节、祭祖节，节期在仲春与暮春之交。
         * 清明节源自上古时代的祖先信仰与春祭活动，兼具自然与人文两大内涵，既是自然节气点，也是传统节日。
         * 
         * 清明节是传统的重大春祭节日，扫墓祭祀、缅怀祖先，是中华民族自古以来的优良传统，
         * 不仅有利于弘扬孝道亲情、唤醒家族共同记忆，还可促进家族成员乃至民族的凝聚力和认同感。
         * 清明节融汇自然节气与人文风俗为一体，是天时地利人和的合一，
         * 充分体现了中华民族先祖们追求“天、地、人”的和谐合一，讲究顺应天时地宜、遵循自然规律的思想。         *
         * 清明节的节俗丰富，扫墓祭祖与踏青郊游是清明节的两大礼俗主题，这两大传统礼俗主题在中国自古传承，至今不辍。
         *
         * 清明节是中华民族古老的节日，既是一个扫墓祭祖的肃穆节日，也是人们亲近自然、踏青游玩、享受春天乐趣的欢乐节日。
         * 清明节气处在公历4月5号前后，即春分后第15日。
         * 这一时节，生气旺盛、阴气衰退，万物“吐故纳新”，大地呈现春和景明之象，正是郊外踏青春游与行清墓祭的好时节。
         * 清明祭祖节期很长，有10日前8日后及10日前10日后两种说法，这近20天内均属清明祭祖节期内。
         *
         * 清明节与春节、端午节、中秋节并称为中国四大传统节日。
         * 除了中国，世界上还有一些国家和地区也过清明节，比如越南、韩国、马来西亚、新加坡等。
         *
         * 2006年5月20日，中华人民共和国文化部申报的清明节经国务院批准列入第一批国家级非物质文化遗产名录（类别：民俗；编号：Ⅹ-2）。
         */
    }
}