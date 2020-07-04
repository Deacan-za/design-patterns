using System;
using Command.Receiver;

namespace Command.Commands
{
  public class CalculatorCommand: Command
  {

    private char _operator;
    private int _operand;
    private readonly Calculator _calculator;

    public CalculatorCommand(char @operator, int operand, Calculator calculator)
    {
      _operator = @operator;
      _operand = operand;
      _calculator = calculator;
    }

    public char Operator
    {
      set => _operator = value;
    }

    public int Operand
    {
      set => _operand = value;
    }


    public override void Execute()
    {
      _calculator.Operation(_operator, _operand);
    }

    public override void UnExecute()
    {
      _calculator.Operation(Undo(_operator), _operand);
    }

    private static char Undo(char @operator)
    {
      switch (@operator)
      {
        case '+':
          return '-';
        case '-':
          return '+';
        case '*':
          return '/';
        case '/':
          return '*';
        default:
          throw new ArgumentException("@Operator");

      }
    }
  }
}
