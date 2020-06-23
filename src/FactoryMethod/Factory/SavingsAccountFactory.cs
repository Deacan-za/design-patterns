using System;
using System.Diagnostics;
using FactoryMethod.Models;

namespace FactoryMethod.Factory
{
  public class SavingsAccountFactory: ICreditUnionFactory
  {
    public ISavingsAccount GetSavingsAccount(string accNum)
    {
      var split = accNum.Split('-');
      switch (split[0])
      {
        case "City":
          return new CitySavingsAccount();
          
        case "National":
          return new NationalSavingsAccount();

        default:
          throw new ArgumentException("Invalid Account Number");
      }
    }
  }
}
