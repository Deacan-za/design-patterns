using System;
using State.States;

namespace State.Models
{
  /// <summary>
  /// Context Class
  /// </summary>
  internal class Account
  {
    private States.State _state;
    private string _owner;

    public Account(string owner)
    {
      _owner = owner;
      _state = new StandardState(0.0, this);
    }

    public double Balance => _state.Balance;

    public States.State State
    {
      get => _state;
      set => _state = value;
    }

    public void Deposit(double amount)
    {
      _state.Deposit(amount);
      Console.WriteLine($"Deposit {amount} ---" 
                        + $"\nBalance = {Balance} " 
                        + $"\nStatus = {State.GetType().Name}");
    }

    public void Withdrawal(double amount)
    {
      _state.Withdraw(amount);
      Console.WriteLine($"Withdrew {amount} ---"
                        + $"\nBalance = {Balance} "
                        + $"\nStatus = {State.GetType().Name}");
    }

    public void PayInterest()
    {
      _state.PayInterest();
      Console.WriteLine($"Interest Paid ---"
                        + $"\nBalance = {Balance} "
                        + $"\nStatus = {State.GetType().Name}");
    }
  }
}
