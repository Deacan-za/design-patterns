using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

      Console.WriteLine(theCar.GetDescription());
      Console.WriteLine($"{theCar.GetPrice():C2}");
      Console.ReadKey();
    }
  }
}
