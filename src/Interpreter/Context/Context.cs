using System.Runtime.Remoting.Messaging;

namespace Interpreter.Patterns.Context
{
  public class Context
  {
    private string _input;
    private int _output;

    public Context(string input)
    {
      _input = input;
    }

    public string Input
    {
      get => _input;
      set => _input = value;
    }

    public int Output
    {
      get => _output;
      set => _output = value;
    }
  }
}
