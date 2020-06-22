using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethod.Factory;

namespace FactoryMethod
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      var factory = new SavingsAccountFactory();
      var cityAcc = factory.GetSavingsAccount("City-321");
      var nationalAcc = factory.GetSavingsAccount("National-978");

      Console.WriteLine($"My city balance is {cityAcc.Balance}" + 
                        $" and my national balance is {nationalAcc.Balance}");
      Console.ReadKey();
    }
  }
}
