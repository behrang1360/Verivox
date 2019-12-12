using NUnit.Framework;
namespace TariffComparisonTest
{   
    [TestFixture]
    public class PackageTariff_Calculation
    {            
        [TestCase(3500, 800)]
        [TestCase(4500, 950)]
        [TestCase(6000, 1400)]
        public void PackageTariff_Calucaltion_ReturnFloat(float consumption, float result)
        {
            TariffComparisonApi.Services.PackageTariff tsb = new TariffComparisonApi.Services.PackageTariff();
            var cal_reuslt = tsb.Calculate(consumption);
            Assert.AreEqual(cal_reuslt,result);
        }
    
    }
}