using Cosmos.Business.Extensions.Holiday.Core.Trees;
using Shouldly;
using Xunit;

namespace Cosmos.Business.Extensions.Holiday.Tests
{
    public class ContainsTests
    {
        [Fact]
        public void ContainTest()
        {
            var chinaNationalDay = new Cosmos.Business.Extensions.Holiday.Definitions.Asia.China.Public.NationalDay();
            var chinaHkNationalDay=new Cosmos.Business.Extensions.Holiday.Definitions.Asia.HongKong.Public.NationalDay();
            var octNode = new DailyNode();
            
            //add China National Day
            octNode.Add(chinaNationalDay);
            
            //contains check - 1st
            octNode.Contains(chinaNationalDay).ShouldBeTrue();
            octNode.Contains(chinaHkNationalDay).ShouldBeFalse();
            
            //add China HongKong National Day
            octNode.Add(chinaHkNationalDay);
            
            //contains check - 2nd
            octNode.Contains(chinaNationalDay).ShouldBeTrue();
            octNode.Contains(chinaHkNationalDay).ShouldBeTrue();
        }
    }
}