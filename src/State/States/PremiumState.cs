using System.Security.Principal;
using State.Models;

namespace State.States
{
  /// <summary>
  /// Concrete state
  /// </summary>
  internal class PremiumState : State
  {

    public PremiumState(State state): this(state.Balance, state.Account)
    { }

    public PremiumState(double balance, Account account)
    {
      Balance = balance;
      Account = account;
      Initialize();
    }

    private void Initialize()
    {
      interest = 0.05;
      lowerLimit = 1000.0;
      upperLimit = 10000000.0;
    }

    public override void Deposit(double amount)
    {
      Balance += amount;
      StateChangeCheck();
    }

    public override void Withdraw(double amount)
    {
      Balance -= amount;
      StateChangeCheck();
    }

    public override void PayInterest()
    {
      Balance += interest * Balance;
      StateChangeCheck();
    }

    private void StateChangeCheck()
    {
      if (Balance < 0.0)
      {
        Account.State = new OverdrawnState(this);
      }
      else if (Balance < lowerLimit)
      {
        Account.State = new StandardState(this);
      }
    }
  }
}
