using System.Collections.Generic;

namespace Memento
{
  public class CareTaker
  {
    // Where all mementos are saved.
    private readonly List<SystemMemento> _savesStatements = new List<SystemMemento>();

    // Adds memento to the list.
    public void AddMemento(SystemMemento m) => _savesStatements.Add(m);

    // Gets the memento requested from the collection.
    public SystemMemento GetMemento(int index)
    {
      return index > -1 ? _savesStatements[index] : new SystemMemento(string.Empty);
    }


  }
}
