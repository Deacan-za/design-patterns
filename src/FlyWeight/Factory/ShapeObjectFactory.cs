using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using FlyWeight.Shapes;

namespace FlyWeight.Factory
{
  /// <summary>
  /// The FlyWeight Factory class.
  /// </summary>
  public class ShapeObjectFactory
  {
    Dictionary<string, IShape> shapes = new Dictionary<string, IShape>();

    public int TotalObjectsCreated => shapes.Count;

    public IShape GetShape(string shapeName)
    {
      IShape shape = null;

      if (shapes.ContainsKey(shapeName))
      {
        shape = shapes[shapeName];
      }
      else
      {
        switch (shapeName)
        {
          case "Triangle":
            shape = new Triangle();
            shapes.Add("Triangle", shape);
            break;

          case "Square":
            shape = new Square();
            shapes.Add("Square", shape);
            break;

          default:
            throw new Exception($"Factory can not create a shape of type {shapeName}");
        }
      }
      return shape;
    }

  }
}
