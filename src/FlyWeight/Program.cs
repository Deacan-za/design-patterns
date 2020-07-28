using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlyWeight.Factory;
using FlyWeight.Shapes;

namespace FlyWeight
{
  internal class Client
  {
    private static void Main(string[] args)
    {

      var factory = new ShapeObjectFactory();

      IShape shape = factory.GetShape("Triangle");
      shape.Print();
      shape = factory.GetShape("Triangle");
      shape.Print();
      shape = factory.GetShape("Triangle");
      shape.Print();

      shape = factory.GetShape("Square");
      shape.Print();
      shape = factory.GetShape("Square");
      shape.Print();
      shape = factory.GetShape("Square");
      shape.Print();

      Console.WriteLine($"We have created {factory.TotalObjectsCreated} objects");

      Console.ReadKey();
    }
  }
}
