using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype.Color;

namespace Prototype
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      // Initialize some standard colors.
      ColorController controller = new ColorController
      {
        ["yellow"] = new Color.Color(255, 255, 0),
        ["orange"] = new Color.Color(255,128,0),
        ["purple"] = new Color.Color(128,0,255)
      };

      // User adds personal colors.
      controller["sunny"] = new Color.Color(255,54,0);
      controller["tasty"] = new Color.Color(255, 153, 51);
      controller["rainy"] = new Color.Color(255, 0, 255);

      // User clones selected colors.
      var c1 = controller["yellow"].Clone() as Color.Color;
      var c2 = controller["tasty"].Clone() as Color.Color;
      var c3 = controller["rainy"].Clone() as Color.Color;

      Console.ReadKey();
    }
  }
}
