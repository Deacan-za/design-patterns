using System;

namespace Prototype.Color
{
  public class Color: ColorProtoType
  {
    private int _yellow;
    private int _orange;
    private int _purple;

    public Color(int yellow, int orange, int purple)
    {
      _yellow = yellow;
      _orange = orange;
      _purple = purple;
    }

    public override ColorProtoType Clone()
    {
      Console.WriteLine($"RGB color is cloned to: {_yellow}, {_orange}, {_purple}");
      return MemberwiseClone() as ColorProtoType;
    }
  }
}
