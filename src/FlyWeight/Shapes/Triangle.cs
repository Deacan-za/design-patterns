using System;

namespace FlyWeight.Shapes
{
  /// <summary>
  ///  Concrete FlyWeight Class.
  /// </summary>
  public class Triangle: IShape
  {
    public void Print()
    {
      Console.WriteLine($"Printing {nameof(Triangle)}");
    }
  }
}
