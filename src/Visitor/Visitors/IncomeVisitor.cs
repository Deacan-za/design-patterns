using System;
using Visitor.Elements;

namespace Visitor.Visitors
{
  public class IncomeVisitor: IVisitor
  {
    public void Visit(Element element)
    {
      if (!(element is Employee employee))
      {
        return;
      }

      // provide 10% pay rise
      employee.Income *= 1.10;
      Console.WriteLine($"{employee.GetType().Name} {employee.Name}'s new income: {employee.Income}");

    }
  }
}
