using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer.Observer;
using Observer.Subject;

namespace Observer
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      ICelebrity gClooney = new GClooney("I love my wife");
      ICelebrity tSwift = new TSwift("1981 is now my favorite number");

      IFan firstFan = new Fan();
      IFan secondFan = new Fan();

      gClooney.AddFollower(firstFan);
      tSwift.AddFollower(secondFan);

      gClooney.Tweet = "My wife didn't force me to Tweet";
      tSwift.Tweet = "I love my new music";

      Console.ReadKey();
    }
  }
}
