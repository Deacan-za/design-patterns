using System;

namespace Bridge.Senders
{
  public class WebServiceSender: IMessageSender
  {
    public void SendMessage(string subject, string body)
    {
      const string messageType = "Web Service";
      Console.WriteLine($"{messageType}\n" +
                        $"--------------\n" +
                        $"Subject: {subject} from {messageType}\n" +
                        $"Body: {body}\n\n");
    }
  }
}
