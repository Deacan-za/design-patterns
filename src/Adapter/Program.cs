using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adapter.Adapter;
using Adapter.Models;

namespace Adapter
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      Console.WriteLine("Employee list from a 3rd party application " +
                        $"\n3rd party application returns string array " +
                        $"\nclient application requires a List<string>"  +
                        $"\n--------------------------------------------------------");

      ITarget adapter = new EmployeeAdapter();

      foreach (var employee in adapter.GetEmployees())
      {
        Console.WriteLine(employee);
      }

      Console.ReadLine();
    }
  }
}
