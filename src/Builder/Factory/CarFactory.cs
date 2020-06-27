using Builder.Builder;
using Builder.Models;

namespace Builder.Factory
{
  public class CarFactory
  {
    public Car Build(CarBuilder builder)
    {
      builder.SetHorsePower();
      builder.SetTopSpeed();
      builder.SetMostImpressiveFeature();
      return builder.GetCar();
    }
  }
}
