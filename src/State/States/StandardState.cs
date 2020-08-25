using State.Models;

namespace State.States
{
  /// <summary>
  /// Concrete states
  /// </summary>
  internal class StandardState : State
  {
    public StandardState(State state): this(state.Balance, state.Account)
    {
      
    }

    public StandardState(double balance, Account account)
    {
      Balance = balance;
      Account = account;
      Initialize();
    }

    private void Initialize()
    {
      interest = 0.0;
      lowerLimit = 0.0;
      upperLimit = 1000.0;
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
      if (Balance < lowerLimit)
      {
        Account.State = new OverdrawnState(this);
      }
      else if(Balance > upperLimit)
      {
        Account.State = new PremiumState(this);
      }
    }
  }
}
