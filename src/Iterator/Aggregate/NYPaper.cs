using System.Collections.Generic;
using Iterator.Iterator;

namespace Iterator.Aggregate
{
  public class NYPaper : INewspaper
  {
    private List<string> _reporters;

    public NYPaper()
    {
      _reporters = new List<string>
      {
        "Darrell Mustafa",
        "Haley Hope",
        "Keiren Benton",
        "Asha Ruiz",
        "Corinne Gibson"
      };
    }

    public IIterator CreateIterator()
    {
      return new NYPaperIterator(_reporters);
    }
  }
}
