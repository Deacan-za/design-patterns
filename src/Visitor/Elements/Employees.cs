using System;
using System.Collections.Generic;
using Visitor.Visitors;

namespace Visitor.Elements
{
  public class Employees
  {
    private List<Employee> _employees = new List<Employee>();

    public void Attach(Employee employee)
    {
      _employees.Add(employee);
    }

    public void Detach(Employee employee)
    {
      _employees.Remove(employee);
    }

    public void Accept(IVisitor visitor)
    {
      foreach (var employee in _employees)
      {
        employee.Accept(visitor);
      }
      Console.WriteLine();
    }
  }
}
