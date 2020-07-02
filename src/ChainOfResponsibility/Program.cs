using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChainOfResponsibility.Handler;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      IApprover ronny = new Director();
      IApprover bobby = new VicePresident();
      IApprover ricky = new President();

      ronny.SetSuccessor(bobby);
      bobby.SetSuccessor(ricky);

      Purchase p = new Purchase
      {
        Number = 8884,
        Amount = 350.00,
        Purpose = "Assets"
      };

      ronny.ProcessRequest(p);

      p = new Purchase
      {
        Number = 5555,
        Amount = 22000.50,
        Purpose = "PARTY!!"
      };

      ronny.ProcessRequest(p);

      p = new Purchase
      {
        Number = 5675,
        Amount = 33390.10,
        Purpose = "project poison"
      };

      ronny.ProcessRequest(p);

      p = new Purchase
      {
        Number = 5676,
        Amount = 144400.00,
        Purpose = "project bbd"
      };

      ronny.ProcessRequest(p);

      Console.ReadKey();
    }
  }
}
