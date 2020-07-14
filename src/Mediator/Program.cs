using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediator.Actors;
using Mediator.ChatRoomMediator;

namespace Mediator
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      // Create ChatRoom
      var chatRoom = new ChatRoom();

      Participant eddie = new Actor("Eddie");
      Participant jen = new Actor("Jen");
      Participant bruce = new Actor("Bruce");
      Participant tom = new Actor("Tom");
      Participant tony = new NonActor("Tony");

      chatRoom.Register(eddie);
      chatRoom.Register(jen);
      chatRoom.Register(bruce);
      chatRoom.Register(tom);
      chatRoom.Register(tony);

      tony.Send("Tom", "Hey Tom, I got a mission for you");
      jen.Send("Bruce", "Teach me something");
      bruce.Send("Eddie", "Will the real Eddie please stand up");
      jen.Send("Tom", "Do you like maths");
      tom.Send("Tony", "Are you Iron-man?");

      Console.ReadKey();

    }
  }
}
