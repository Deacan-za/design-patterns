using System.Collections.Generic;

namespace Strategy.Strategies
{
  /// <summary>
  /// The 'Strategy' abstract class
  /// </summary>
  public abstract class SortStrategy
  {
    public abstract void Sort(List<string> list);
  }
}
