using System;
using System.Collections.Generic;
using Strategy.Strategies;

namespace Strategy.Context
{
  /// <summary>
  /// Context Class
  /// </summary>
  public class SortedList
  {
    private List<string> _list = new List<string>();
    private SortStrategy _sortStrategy;

    public void SetSortStrategy(SortStrategy strategy)
    {
      _sortStrategy = strategy;
    }

    public void Add(string name)
    {
      _list.Add(name);
    }

    public void Sort()
    {
      _sortStrategy.Sort(_list);

      _list.ForEach(
        item =>
        {
          Console.WriteLine($" {item}");
        });
      Console.WriteLine();
    }

  }
}
