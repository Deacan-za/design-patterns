using System;
using Observer.Subject;

namespace Observer.Observer
{
  public class Fan: IFan
  {
    public void Update(ICelebrity celebrity)
    {
      Console.WriteLine($"Fan Notified. Tweet of {celebrity.FullName}: " + 
                        $"{celebrity.Tweet}");
    }
  }
}
