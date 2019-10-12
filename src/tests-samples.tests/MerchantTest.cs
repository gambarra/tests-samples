using System;
using tests_samples.tests.Builders;
using Xunit;

namespace tests_samples.tests
{
    public class UnitTest1
    {
        [Fact]
        public void CreateMerchantTest()
        {

            var merchant = MerchantBuilder.Instance()
                .WithDefault()
                .Build();
            
            Assert.Equal("name_default",merchant.Name);
        }

        [Fact]
        public void CreateMerchantOtherNameTest()
        {
            var merchant = MerchantBuilder.Instance()
                .WithDefault()
                .WithName("new_name")
                .Build();
            
            Assert.Equal("new_name",merchant.Name);
        }
    }
}
