using System.Collections.Generic;

namespace Prototype.Color
{
  public class ColorController
  {
    private Dictionary<string, ColorProtoType> _colors = new Dictionary<string, ColorProtoType>();

    // Indexer
    public ColorProtoType this[string key]
    {
      get => _colors[key];
      set => _colors.Add(key, value);
    }
  }
}
