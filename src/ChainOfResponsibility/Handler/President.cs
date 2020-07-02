using System;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handler
{
  public class President: Approver
  {
    public override void ProcessRequest(Purchase purchase)
    {
      if (purchase.Amount < 100000.0)
      {
        Console.WriteLine($"{this.GetType().Name} approve request # {purchase.Number} for {purchase.Purpose}");
      }
      else
      {
        Console.WriteLine($"Request # {purchase.Number} ({purchase.Purpose}) requires an executive meeting");
      }
    }
  }
}
