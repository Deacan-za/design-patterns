using System;
using System.Runtime.Remoting.Messaging;
using Mediator.ChatRoomMediator;

namespace Mediator.Actors
{
  public abstract class Participant
  {
    private string _name;

    protected Participant(string name)
    {
      _name = name;
    }

    public string Name => _name;

    public IChatRoom ChatRoom { get; set; }

    public void Send(string to, string message)
    {
      ChatRoom.Send(Name, to, message);
    }

    public virtual void Receive(string from, string message)
    {
      Console.WriteLine($"{from} to {Name}: {message}");
    }
  }
}
