namespace Bridge.Messages
{
  // The 'RefinedAbstraction' class.
  public class SystemMessage: Message
  {
    public override void Send()
    {
      MessageSender.SendMessage(Subject, Body);
    }
  }
}
