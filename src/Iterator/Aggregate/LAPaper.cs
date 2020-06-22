using System.CodeDom;
using Iterator.Iterator;

namespace Iterator.Aggregate
{
  public class LAPaper: INewspaper
  {
    private string[] _reporters;

    public LAPaper()
    {
      _reporters = new[]
      {
        "Hamish Gay",
        "Ayla Ryan",
        "Kamal Woodley",
        "Umer Cortes",
        "Heena Hayes"
      };
    }

    public IIterator CreateIterator()
    {
      return new LAPaperIterator(_reporters);
    }
  }
}
