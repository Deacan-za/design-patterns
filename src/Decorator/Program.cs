using System;
using Decorator.Decorators;
using Decorator.Models;

namespace Decorator
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      Car theCar = new CompactCar();
      theCar = new Navigation(theCar);
      theCar = new SunRoof(theCar);
      theCar = new LeatherSeats(theCar);

      Car fCar = new FullSizedCar();
      fCar = new Navigation(fCar);
      fCar = new SunRoof(fCar);
      fCar = new LeatherSeats(fCar);

      Console.WriteLine(theCar.GetDescription());
      Console.WriteLine($"{theCar.GetPrice():C2}");
      Console.WriteLine(fCar.GetDescription());
      Console.WriteLine($"{fCar.GetPrice():C2}");
      Console.ReadKey();
    }
  }
}
