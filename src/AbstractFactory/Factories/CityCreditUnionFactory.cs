using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Models;

namespace AbstractFactory.Factories
{
  public class CityCreditUnionFactory: ICreditUnionFactory
  {
    public ILoanAccount CreateLoanAccount()
    {
      return new CityLoanAccount();
    }

    public ISavingsAccount CreateSavingsAccount()
    {
      return new CitySavingsAccount();
    }
  }
}
