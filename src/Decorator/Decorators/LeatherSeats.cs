using Decorator.Models;

namespace Decorator.Decorators
{
  public class LeatherSeats: CarDecorator
  {
    public LeatherSeats(Car car) : base(car)
    {
      Description = "Leather Seats";
    }

    public override string GetDescription() => $"{Car.GetDescription()}, {Description}";
    public override double GetPrice() => Car.GetPrice() + 2500;

  }
}
