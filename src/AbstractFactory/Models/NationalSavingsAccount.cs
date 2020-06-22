using System;

namespace AbstractFactory.Models
{
  public class NationalSavingsAccount: ISavingsAccount
  {
    public NationalSavingsAccount()
    {
      Console.WriteLine("Returned National Savings Account");
    }
  }
}
