using System;

namespace Mediator.Actors
{
  public class NonActor: Participant
  {
    public NonActor(string name) : base(name)
    {
    }

    public override void Receive(string @from, string message)
    {
      Console.WriteLine("To a Non-Actor");
      base.Receive(@from, message);
    }
  }
}
