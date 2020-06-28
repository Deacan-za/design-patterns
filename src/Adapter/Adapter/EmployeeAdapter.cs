using System.Collections.Generic;
using System.Linq;
using Adapter.Models;

namespace Adapter.Adapter
{
  public class EmployeeAdapter: ThirdPartEmployee, ITarget
  {
    public List<string> GetEmployees()
    {
      return GetEmployeeList().ToList();
    }
  }
}
