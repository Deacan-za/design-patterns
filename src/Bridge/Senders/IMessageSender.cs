namespace Bridge.Senders
{

  // The 'Bridge/Implementor' interface.
  public interface IMessageSender
  {
    void SendMessage(string subject, string body);
  }
}
