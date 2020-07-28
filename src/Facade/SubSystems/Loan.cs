using System;
using Facade.Models;

namespace Facade.SubSystems
{
  public class Loan
  {
    public bool HasNoBadLoans(Student student)
    {
      Console.WriteLine($"Verify loan for {student.Name}");
      return true;
    }
  }
}
