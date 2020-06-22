using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Factories;
using AbstractFactory.Models;

namespace AbstractFactory
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      var accountNumbers = new List<string>
      {
        "City-123",
        "National-123",
        "Chase-123"
      };

      foreach (var number in accountNumbers)
      {
        ICreditUnionFactory abstractFactory = ProviderFactory.GetCreditUnionFactory(number);

        if (abstractFactory != null)
        {
          Console.WriteLine($"Account number: {number}");
          ILoanAccount loan = abstractFactory.CreateLoanAccount();
          ISavingsAccount savings = abstractFactory.CreateSavingsAccount();
          Console.WriteLine(Environment.NewLine);
        }
        else
        {
          Console.WriteLine($"Sorry. The account number: {number} is invalid");
        }
      }

      Console.ReadLine();
    }
  }
}
