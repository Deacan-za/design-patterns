using Decorator.Models;

namespace Decorator.Decorators
{
  public class SunRoof: CarDecorator
  {
    public SunRoof(Car car) : base(car)
    {
      Description = "Sun Roof";
    }

    public override string GetDescription() => $"{Car.GetDescription()}, {Description}";
    public override double GetPrice() => Car.GetPrice() + 2500;
  }
}
