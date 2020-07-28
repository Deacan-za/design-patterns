using System;

namespace Bridge.Senders
{
  // The 'Concrete Bridge/Implementor' class.
  public class TextSender: IMessageSender
  {
    public void SendMessage(string subject, string body)
    {
      const string messageType = "Text";
      Console.WriteLine($"{messageType}\n" + 
                        $"--------------\n" + 
                        $"Subject: {subject} from {messageType}\n" + 
                        $"Body: {body}\n\n");
    }
  }
}
