using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using State.Models;

namespace State
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      Account account = new Account("Bob Dylan");

      account.Deposit(490.0);
      account.Deposit(390.0);
      account.Deposit(540.0);

      account.PayInterest();

      account.Withdrawal(2200.0);
      account.Withdrawal(1300.0);

      Console.ReadKey();

    }
  }
}
