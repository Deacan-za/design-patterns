using System;
using Facade.Models;

namespace Facade.SubSystems
{
  public class Credit
  {
    public bool HasGoodCredit(Student student)
    {
      Console.WriteLine($"Verify credit for {student.Name}");
      return true;
    }
  }
}
