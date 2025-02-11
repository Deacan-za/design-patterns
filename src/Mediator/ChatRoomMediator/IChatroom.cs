﻿using Mediator.Actors;

namespace Mediator.ChatRoomMediator
{
  public interface IChatRoom
  {
    void Register(Participant participant);
    void Send(string from, string to, string message);
  }
}
