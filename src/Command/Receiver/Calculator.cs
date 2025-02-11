﻿using System;

namespace Command.Receiver
{
  public class Calculator
  {
    private int _curr = 0;

    public void Operation(char @operator, int operand)
    {
      switch (@operator)
      {
        case '+':
          _curr += operand;
          break;
        case '-':
          _curr -= operand;
          break;
        case '*':
          _curr *= operand;
          break;
        case '/':
          _curr /= operand;
          break;
        default:
          throw new ArgumentException("@operator");
      }

      Console.WriteLine($"Current value = {_curr} (following {@operator} {operand})");
    }
  }
}
