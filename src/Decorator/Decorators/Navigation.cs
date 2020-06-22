using Decorator.Models;

namespace Decorator.Decorators
{
  public class Navigation: CarDecorator
  {
    public Navigation(Car car) : base(car)
    {
      Description = "Navigation";
    }

    public override string GetDescription() => $"{Car.GetDescription()}, {Description}";
    public override double GetPrice() => Car.GetPrice() + 2500;
  }
}
