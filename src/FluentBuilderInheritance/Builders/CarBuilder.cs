using FluentBuilderInheritance.Models;

namespace FluentBuilderInheritance.Builders
{
  public class CarBuilder<TSelf> : CarFeatureBuilder<CarBuilder<TSelf>> where TSelf : CarBuilder<TSelf>
  {
    public Car Build()
    {
      return Car;
    }
  }
}
