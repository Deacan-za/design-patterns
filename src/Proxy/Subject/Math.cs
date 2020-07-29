using System;
using System.ComponentModel.Design;

namespace Proxy.Subject
{
  /// <summary>
  /// The 'Real Subject' class.
  /// </summary>
  public class Math: IMath
  {
    public double Add(double x, double y)
    {
      return x + y;
    }

    public double Subtract(double x, double y)
    {
      return x - y;
    }

    public double Multiple(double x, double y)
    {
      return x * y;
    }

    public double Divide(double x, double y)
    {
      if (y.Equals(0))
      {
        throw new Exception("Can not divide by zero.");
      }

      return x / y;
    }
  }
}
