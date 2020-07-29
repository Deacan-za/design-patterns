namespace Memento
{
  public class SystemMemento
  {
    // The statement stored int he memento class.
    private readonly string _statement;

    // Save a new statement string tot he memento object
    public SystemMemento(string statement)
    {
      _statement = statement;
    }

    // Return the value stored in statement
    public string GetState() => _statement;
  }
}
