using System;

namespace AbstractFactory.Models
{
  public class CityLoanAccount: ILoanAccount
  {
    public CityLoanAccount()
    {
      Console.WriteLine("Returned City Loan Account");
    }
  }
}
