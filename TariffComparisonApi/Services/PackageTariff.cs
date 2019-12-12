using System;

namespace TariffComparisonApi.Services
{
  public sealed class PackageTariff : TarrifCalculation, IProduct
    {
        public string Name { get; set; }

        private readonly float baseConsumption;
        private readonly float kwhCost;
        private readonly float fixedPrice;

        public PackageTariff()
        {
            baseConsumption = 4000;
            kwhCost = 30;
            fixedPrice = 800;
        }

        public override float Calculate(float consumption)
        {
            if (consumption <= 0)
                throw new Exception("Input value cannot be less than one");

            if (consumption <= baseConsumption)
                return fixedPrice;

            float extraConsumption = consumption - baseConsumption;

            return fixedPrice + (extraConsumption * kwhCost) / 100;

        }
    }
}