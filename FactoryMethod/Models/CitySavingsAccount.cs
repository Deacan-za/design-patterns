using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Models
{
  public class CitySavingsAccount: SavingsAccount
  {
    public CitySavingsAccount()
    {
      Balance = 5000;
    }
  }
}
