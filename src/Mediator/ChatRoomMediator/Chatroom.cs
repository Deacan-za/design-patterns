using System.Collections.Generic;
using Mediator.Actors;

namespace Mediator.ChatRoomMediator
{
  public class ChatRoom: IChatRoom
  {

    private Dictionary<string, Participant> _participants = new Dictionary<string, Participant>();

    public void Register(Participant participant)
    {
      if (!_participants.ContainsValue(participant))
      {
        _participants[participant.Name] = participant;
      }

      participant.ChatRoom = this;
    }

    public void Send(string @from, string to, string message)
    {
      var participant = _participants[to];

      participant?.Receive(@from, message);
    }
  }
}
