using System;

namespace State.States
{
  /// <summary>
  /// Concrete State
  /// </summary>
  internal class OverdrawnState: State
  {

    private double _serviceFee;

    public OverdrawnState(State state)
    {
      Balance = state.Balance;
      Account = state.Account;
      Initialize();
    }

    private void Initialize()
    {
      interest = 0.0;
      lowerLimit = -100.00;
      upperLimit = 0.0;
      _serviceFee = 15.00;
    }

    public override void Deposit(double amount)
    {
      Balance += amount;
      StateChangeCheck();
    }

    public override void Withdraw(double amount)
    {
      amount = amount - _serviceFee;
      Console.WriteLine($"No finds available for withdrawal");
    }

    public override void PayInterest()
    {
      throw new System.NotImplementedException();
    }

    private void StateChangeCheck()
    {
      if (Balance > upperLimit)
      {
        Account.State = new StandardState(this);
      }
    }
  }
}
