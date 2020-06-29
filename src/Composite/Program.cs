using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composite.Models;

namespace Composite
{
  internal class Program
  {
    /// <summary>
    /// This code demonstrates the composite pattern for an application where
    /// any employee can see their own performance record. The supervisor can
    /// see their own and their subordinate's performance record.
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {
      #region Employees
      Employee ricky = new Employee
      {
        EmployeeId = 1,
        Name = "ricky",
        Rating = 3
      };

      Employee mike = new Employee
      {
        EmployeeId = 2,
        Name = "mike",
        Rating = 4
      };

      Employee maryann = new Employee
      {
        EmployeeId = 3,
        Name = "maryann",
        Rating = 5
      };

      Employee ginger = new Employee
      {
        EmployeeId = 4,
        Name = "ginger",
        Rating = 3
      };

      Employee olive = new Employee
      {
        EmployeeId = 5,
        Name = "olive",
        Rating = 4
      };

      Employee candy = new Employee
      {
        EmployeeId = 6,
        Name = "ginger",
        Rating = 5
      };
      #endregion

      #region Supervisors
      Supervisor ronny = new Supervisor
      {
        EmployeeId = 7,
        Name = "ronnie",
        Rating = 3
      };


      Supervisor bobby = new Supervisor
      {
        EmployeeId = 8,
        Name = "bobby",
        Rating = 3
      }; 
      #endregion

      ronny.AddSubordinate(ricky);
      ronny.AddSubordinate(mike);
      ronny.AddSubordinate(maryann);

      bobby.AddSubordinate(ginger);
      bobby.AddSubordinate(olive);
      bobby.AddSubordinate(candy);


      Console.WriteLine($"\n--- Employee can see their performance " + 
                        $"summary -------");
      ricky.PerformanceSummary();

      Console.WriteLine($"\n--- Supervisor can also see their " +
                        $"subordinates performance summary -------");
      ronny.PerformanceSummary();
      foreach (var employee in ronny.ListSubordinates)
      {
        employee.PerformanceSummary();
      }

      Console.ReadLine();
    }
  }
}
