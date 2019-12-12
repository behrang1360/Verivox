using NUnit.Framework;

namespace TariffComparisonTest
{

    [TestFixture]
    public class BasicTariff_Calucaltion
    {
        [TestCase(3500, 830)]
        [TestCase(4500, 1050)]
        [TestCase(6000, 1380)]
        public void BasicTariff_Calucaltion_ReturnFloat(float consumption, float result)
        {
            TariffComparisonApi.Services.BasicTariff tsb = new TariffComparisonApi.Services.BasicTariff();
            var cal_reuslt = tsb.Calculate(consumption);
            Assert.AreEqual(cal_reuslt,result);
        }
    }
}