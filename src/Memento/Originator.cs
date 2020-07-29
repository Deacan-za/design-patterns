using  static System.Diagnostics.Debug;

namespace Memento
{
  public class Originator
  {
    private string _statement;

    // Sets the value for the statement.
    public void Set(string newStatement)
    {
      WriteLine("------");
      WriteLine($"From Originator: Current Version of statement\n " + 
                $"+ {newStatement}\n");
      _statement = newStatement;
    }

    // Creates a new Memento with a new statement.
    public SystemMemento StoreInMemento()
    {
      WriteLine("From Originator: Saving to Memento");
      return new SystemMemento(_statement);
    }

    // Gets the statement currently stored in the memento.
    public string RestoreFromMemento(SystemMemento m)
    {
      _statement = m.GetState();
      WriteLine($"From the Originator: Previous statement saved in Memento\n" + 
                $"{_statement}\n");

      return _statement;
    }
  }
}
