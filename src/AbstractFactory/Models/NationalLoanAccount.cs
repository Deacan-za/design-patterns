using System;

namespace AbstractFactory.Models
{
  public class NationalLoanAccount: ILoanAccount
  {
    public NationalLoanAccount()
    {
      Console.WriteLine("Returned National Loan Account");
    }
  }
}
