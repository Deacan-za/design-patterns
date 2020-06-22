using System;

namespace AbstractFactory.Factories
{
  public class ProviderFactory
  {
    public static ICreditUnionFactory GetCreditUnionFactory(string accNum)
    {
      var split = accNum.Split('-');
      switch (split[0])
      {
        case "City":
          return new CityCreditUnionFactory();

        case "National":
          return new NationalCreditUnionFactory();

        default:
          return null;
      }
    }
  }
}

