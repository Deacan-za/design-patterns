using System;

namespace Template.Templates
{
  /// <summary>
  /// Abstraction
  /// </summary>
  public abstract class DocumentReader
  {
    public void LoadFile()
    {
      Console.WriteLine("Document File Loaded");
    }

    public abstract void InterpretDocumentFormat();

    public void Open()
    {
      Console.WriteLine("Document File Opens");
    }

    /// <summary>
    /// Template Method
    /// </summary>
    public void OpenDocument()
    {
      LoadFile();
      InterpretDocumentFormat();
      Open();
    }
  }
}
