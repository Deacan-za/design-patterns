using System;
using System.Collections.Generic;
using Command.Commands;
using Command.Receiver;

namespace Command.Invoker
{
  public class User
  {
    private Calculator _calculator = new Calculator();
    private List<Commands.Command> _commands = new List<Commands.Command>();
    private int _current = 0;

    public void Redo(int levels)
    {
      Console.WriteLine($"\n---- Redo {levels} levels");

      for (var i = 0; i < levels; i++)
      {
        if (_current >= _commands.Count - 1)
        {
          continue;
        }

        var command = _commands[_current++];
        command.Execute();
      }
    }

    public void Undo(int levels)
    {
      Console.WriteLine($"\n---- Undo {levels} levels");

      for (var i = 0; i < levels; i++)
      {
        if (_current > 0)
        {
          var command = _commands[--_current] as Commands.Command;
          command.UnExecute();
        }
      }
    }

    public void Compute(char @operator, int operand)
    {
      Command.Commands.Command command = new CalculatorCommand(@operator, operand, _calculator);
      command.Execute();

      _commands.Add(command);
      _current++;
    }
  }
}