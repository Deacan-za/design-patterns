using System;
using Bridge.Messages;
using Bridge.Senders;

namespace Bridge
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      IMessageSender text = new TextSender();
      IMessageSender web = new WebServiceSender();

      Message message = new SystemMessage
      {
        Subject = "A message",
        Body = "Hi there, please accept this message",
        MessageSender = text
      };

      message.Send();

      message.MessageSender = web;

      message.Send();

      Console.ReadKey();
    }
  }
}
