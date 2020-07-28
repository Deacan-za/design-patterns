using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facade.Models;
using Facade.SystemFacades;

namespace Facade
{
  internal class Client
  {
    private static void Main(string[] args)
    {
      // Create Facade.
      CollegeLoan collegeLoan = new CollegeLoan();

      // Evaluate requested loan.
      Student student = new Student()
      {
        Name = "Bob"
      };

      var eligible = collegeLoan.IsEligible(student, 10000);

      Console.WriteLine(!eligible ? $"{student.Name} is not eligible for the 10000 loan" : $"{student.Name} is eligible for the 10000 loan");
      Console.ReadKey();
    }
  }
}
