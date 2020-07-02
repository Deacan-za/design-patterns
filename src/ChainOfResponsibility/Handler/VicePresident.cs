using System;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handler
{
  public class VicePresident: Approver
  {
    public override void ProcessRequest(Purchase purchase)
    {
      if (purchase.Amount < 25000.0)
      {
        Console.WriteLine($"{this.GetType().Name} approve request # {purchase.Number} for {purchase.Purpose}");
      }
      else
      {
        Successor?.ProcessRequest(purchase);
      }
    }
  }
}
