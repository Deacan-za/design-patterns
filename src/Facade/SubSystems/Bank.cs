using System;
using Facade.Models;

namespace Facade.SubSystems
{
  public class Bank
  {
    public bool HasSufficientSavings(Student student, int amount)
    {
      Console.WriteLine($"Verify bank for {student.Name}");
      return true;
    }
  }
}
