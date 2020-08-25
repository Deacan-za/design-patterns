using System.Security.AccessControl;
using System.Security.Principal;
using State.Models;

namespace State.States
{
  /// <summary>
  /// Abstraction
  /// </summary>
  internal abstract class State
  {
    public Account Account { get; set; }
    public double Balance { get; set; }

    protected double interest;
    protected double lowerLimit;
    protected double upperLimit;

    public abstract void Deposit(double amount);
    public abstract void Withdraw(double amount);
    public abstract void PayInterest();
  }
}
