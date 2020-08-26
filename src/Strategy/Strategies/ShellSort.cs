using System;
using System.Collections.Generic;

namespace Strategy.Strategies
{
  /// <summary>
  /// Concrete Strategy
  /// </summary>
  public class ShellSort : SortStrategy
  {
    public override void Sort(List<string> list)
    {
      Console.WriteLine("Shell Sorted List!!");
    }
  }
}
