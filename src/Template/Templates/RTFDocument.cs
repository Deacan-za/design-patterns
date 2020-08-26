using System;

namespace Template.Templates
{
  public class RtfDocument : DocumentReader
  {
    public override void InterpretDocumentFormat()
    {
      Console.WriteLine("Document file processed with RTF interpreter");
    }
  }
}
