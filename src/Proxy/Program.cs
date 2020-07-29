using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proxy.SystemProxy;

namespace Proxy
{
  internal class Client
  {
    private static void Main(string[] args)
    {
      // Create the proxy.
      var proxy = new CalculatorProxy();

      // Do some maths.
      Console.WriteLine("Calculations");
      Console.WriteLine("--------------");
      Console.WriteLine($"\n10 + 5 = {proxy.Add(10, 5)}" );
      Console.WriteLine($"\n10 - 5 = {proxy.Subtract(10, 5)}");
      Console.WriteLine($"\n10 * 5 = {proxy.Multiple(10, 5)}");
      Console.WriteLine($"\n10 / 5 = {proxy.Divide(10, 5)}");

      Console.ReadKey();
    }
  }
}
