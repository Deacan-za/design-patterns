using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Elements;
using Visitor.Visitors;

namespace Visitor
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      // Setup Employees collection
      var employees = new Employees();
      employees.Attach(new Clerk());
      employees.Attach(new Director());
      employees.Attach(new President());

      // Employees are 'Visited'
      employees.Accept(new IncomeVisitor());
      employees.Accept(new VacationVisitor());

      Console.ReadKey();
    }
  }
}
