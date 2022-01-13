using FluentBuilderInheritance.Models;

namespace FluentBuilderInheritance.Builders;

public class CarInfoBuilder<TSelf> where TSelf : CarInfoBuilder<TSelf>
{
  protected readonly Car Car = new();

  public TSelf SetHorsePower(int horsePower)
  {
    Car.HorsePower = horsePower;
    return (TSelf)this;
  }

  public TSelf SetTopSpeed(int topSpeed)
  {
    Car.TopSpeedMph = topSpeed;
    return (TSelf)this;
  }

}