using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator.Aggregate;
using Iterator.Iterator;

namespace Iterator
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      INewspaper nyt = new NYPaper();
      INewspaper lap = new LAPaper();

      IIterator nypIterator = nyt.CreateIterator();
      IIterator lapIterator = lap.CreateIterator();

      Console.WriteLine("--------------          NY PAPER");
      PrintReporters(nypIterator);

      Console.WriteLine("--------------          LA PAPER");
      PrintReporters(lapIterator);

      Console.ReadKey();
    }

    private static void PrintReporters(IIterator iterator)
    {
      iterator.First();
      while (!iterator.IsDone())
      {
        Console.WriteLine(iterator.Next());
      }
    }
  }
}
