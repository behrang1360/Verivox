using System;

namespace TariffComparisonApi.Services
{
  public sealed class BasicTariff : TarrifCalculation, IProduct
    {
        public string Name { get; set; }

        private readonly float monthlyCharge;
        private readonly int monthCount;
        private readonly float kwhCost;

        public BasicTariff()
        {
            monthlyCharge = 5;
            monthCount = 12;
            kwhCost = 22;
        }

        public override float Calculate(float consumption)
        {
            if (consumption <= 0)
                throw new Exception("Consumption cann't be less than one");

            float charge = monthCount * monthlyCharge;
            float kwhPrice = (consumption * kwhCost) / 100;
            return charge + kwhPrice;
        }
    }
}