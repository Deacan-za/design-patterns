using System;

namespace FlyWeight.Shapes
{
  /// <summary>
  /// Concrete FlyWeight Class.
  /// </summary>
  public class Square: IShape
  {
    public void Print()
    {
      Console.WriteLine($"Printing {nameof(Square)}");
    }
  }
}
