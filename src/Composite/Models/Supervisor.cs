using System;
using System.Collections.Generic;

namespace Composite.Models
{
  // 'Composite' class - will a branch of the tree structure.
  public class Supervisor: IEmployee
  {
    public int EmployeeId { get; set; }
    public string Name { get; set; }
    public int Rating { get; set; }

    // list of all Employees under this superviser, ether leafs or other branches.
    public List<IEmployee> ListSubordinates = new List<IEmployee>();

    public void PerformanceSummary()
    {
      Console.WriteLine($"\nPerformance Summary of supervisor " +
                        $"{Name} is {Rating} out of 5");
    }

    public void AddSubordinate(IEmployee employee)
    {
      ListSubordinates.Add(employee);
    }


  }
}
