using System.Collections.Generic;

namespace Adapter.Models
{
  public class ThirdPartEmployee
  {
    public string[] GetEmployeeList()
    {
      return new[]
      {
        "Peter",
        "Paul",
        "Bob",
        "Bruce"
      };
    }
  }
}
