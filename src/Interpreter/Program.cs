using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Interpreter.Expressions;
using Interpreter.Patterns.Context;
using Context = Interpreter.Patterns.Context.Context;

namespace Interpreter
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      const string roman = "MMXVII";
      var context = new Context(roman);

      // Build the parse tree:
      var tree = new List<Expression>()
      {
        new ThousandExpression(),
        new HundredExpression(),
        new TenExpression(),
        new OneExpression()
      };

      // Interpret
      foreach (var node in tree)
      {
        node.Interpret(context);
        
      }
      Console.WriteLine($"{roman} = {context.Output}");
      Console.ReadKey();
    }
  }
}
