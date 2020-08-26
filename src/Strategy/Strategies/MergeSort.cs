using System;
using System.Collections.Generic;

namespace Strategy.Strategies
{
  /// <summary>
  /// Concrete Strategy
  /// </summary>
  public class MergeSort :SortStrategy
  {
    public override void Sort(List<string> list)
    {
      Console.WriteLine("Merge Sorted List!!");
    }
  }
}
