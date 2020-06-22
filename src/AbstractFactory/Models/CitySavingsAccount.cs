using System;

namespace AbstractFactory.Models
{
  public class CitySavingsAccount: ISavingsAccount
  {
    public CitySavingsAccount()
    {
      Console.WriteLine("Returned City Savings Account");
    }
  }
}
