namespace TariffComparisonApi.Services
{
    public abstract class TarrifCalculation
    {
        public abstract float Calculate(float consumption);
    }
}