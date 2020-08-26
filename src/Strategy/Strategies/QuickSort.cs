using System;
using System.Collections.Generic;

namespace Strategy.Strategies
{
  /// <summary>
  /// Concrete strategy
  /// </summary>
  public class QuickSort : SortStrategy
  {
    public override void Sort(List<string> list)
    {
      list.Sort();
      Console.WriteLine("Quick Sorted List!!");
    }
  }
}
