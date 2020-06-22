using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Models;

namespace Decorator.Decorators
{
  public class CarDecorator: Car
  {
    protected Car Car;

    public CarDecorator(Car car)
    {
      Car = car;
    }

    public override string GetDescription() => Car.GetDescription();

    public override double GetPrice() => Car.GetPrice();
  }
}
