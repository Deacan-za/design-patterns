using System;

namespace Decorator.Models
{
  public class CompactCar: Car
  {
    public CompactCar()
    {
      Description = "Compact Car";
    }

    public override string GetDescription() => Description;

    public override double GetPrice() => 10000.00;
  }
}
