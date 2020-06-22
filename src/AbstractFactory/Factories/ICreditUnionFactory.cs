using AbstractFactory.Models;

namespace AbstractFactory.Factories
{
  public interface ICreditUnionFactory
  {
    ILoanAccount CreateLoanAccount();
    ISavingsAccount CreateSavingsAccount();
  }
}
