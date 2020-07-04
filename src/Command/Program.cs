using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command.Invoker;

// ReSharper disable once InvalidXmlDocComment
/// <summary>
/// This code demonstrates the Command pattern used in a simpe calculator
/// with unlimited number of undo's and redo's. Note the in C# the
/// word 'operator' is a keyword. Prefixing it the a '@' allows using it
/// as an identifer.
/// </summary>
namespace Command
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      // Create the user and let them compute.
      User user = new User();

      user.Compute('+', 100);
      user.Compute('-', 50);
      user.Compute('*', 10);
      user.Compute('/', 2);

      // Undo.
      user.Undo(4);

      // Redo.
      user.Redo(3);

      Console.ReadKey();
    }
  }
}
