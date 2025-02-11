﻿using System.Collections.Generic;
using Observer.Observer;

namespace Observer.Subject
{
  public class TSwift: ICelebrity
  {
    private readonly List<IFan> _fans = new List<IFan>();             // Collection
    private string _tweet;                                            // Backing field

    public TSwift(string tweet)
    {
      _tweet = tweet;
    }


    public string FullName => "Taylor Swift";

    public string Tweet
    {
      get => _tweet;
      set => Notify(value);
    }


    public void Notify(string tweet)
    {
      _tweet = tweet;
      foreach (var fan in _fans)
      {
        fan.Update(this);
      }
    }

    public void AddFollower(IFan fan)
    {
      _fans.Add(fan);
    }

    public void RemoveFollower(IFan fan)
    {
      _fans.Remove(fan);
    }
  }
}
