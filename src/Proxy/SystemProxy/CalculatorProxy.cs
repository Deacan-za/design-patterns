using Proxy.Subject;

namespace Proxy.SystemProxy
{
  public class CalculatorProxy: IMath
  {
    private readonly Math _math = new Math();

    public double Add(double x, double y)
    {
      return _math.Add(x, y);
    }

    public double Subtract(double x, double y)
    {
      return _math.Subtract(x, y);
    }

    public double Multiple(double x, double y)
    {
      return _math.Multiple(x, y);
    }

    public double Divide(double x, double y)
    {
      return _math.Divide(x, y);
    }
  }
}
