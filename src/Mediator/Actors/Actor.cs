using System;
using Mediator.ChatRoomMediator;

namespace Mediator.Actors
{
  public class Actor: Participant
  {
    public Actor(string name): base(name)
    {
      
    }

    public override void Receive(string @from, string message)
    {
      Console.WriteLine("To an Actor");
      base.Receive(@from, message);
    }
  }
}
