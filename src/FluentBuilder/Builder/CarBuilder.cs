using FluentBuilder.Models;

namespace FluentBuilder.Builder
{
  public class CarBuilder
  {
    protected readonly Car Car = new();

    public CarBuilder SetHorsePower(int horsePower)
    {
      Car.HorsePower = horsePower;
      return this;
    }

    public CarBuilder SetTopSpeed(int topSpeed)
    {
      Car.TopSpeedMph = topSpeed;
      return this;
    }

    public CarBuilder SetMostImpressiveFeature(string feature)
    {
      Car.MostImpressiveFeature = feature;
      return this;
    }

    public Car Build()
    {
      return Car;
    }
  }
}
