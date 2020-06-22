using FactoryMethod.Models;

namespace FactoryMethod.Factory
{
  public interface ICreditUnionFactory
  {
    ISavingsAccount GetSavingsAccount(string accNum);
  }
}
