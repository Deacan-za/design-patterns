using System;

namespace Composite.Models
{
  // 'Leaf' class - will be leaf node in the tree structure.
  public class Employee: IEmployee
  {
    public int EmployeeId { get; set; }
    public string Name { get; set; }
    public int Rating { get; set; }
    public void PerformanceSummary()
    {
      Console.WriteLine($"\nPerformance Summary of employee " + 
                        $"{Name} is {Rating} out of 5");
    }
  }
}
