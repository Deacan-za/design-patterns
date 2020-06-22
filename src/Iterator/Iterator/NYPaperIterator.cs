using System.Collections.Generic;
using System.Linq;

namespace Iterator.Iterator
{
  public class NYPaperIterator: IIterator
  {
    private readonly List<string> _reporters;
    private int _current;

    public NYPaperIterator(List<string> reporters)
    {
      _reporters = reporters;
      _current = 0;
    }

    public void First()
    {
      _current = 0;
    }

    public string Next()
    {
      return _reporters.ElementAt(_current++);
    }

    public bool IsDone()
    {
      return _current >= _reporters.Count;
    }

    public string CurrentItem()
    {
      return _reporters.ElementAt(_current);
    }
  }
}
