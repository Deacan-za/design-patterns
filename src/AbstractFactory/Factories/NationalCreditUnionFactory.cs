using AbstractFactory.Models;

namespace AbstractFactory.Factories
{
  public class NationalCreditUnionFactory: ICreditUnionFactory
  {
    public ILoanAccount CreateLoanAccount()
    {
      return new NationalLoanAccount();
    }

    public ISavingsAccount CreateSavingsAccount()
    {
      return new NationalSavingsAccount();
    }
  }
}
