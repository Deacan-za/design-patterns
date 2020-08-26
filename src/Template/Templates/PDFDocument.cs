using System;

namespace Template.Templates
{
  /// <summary>
  /// Concrete Template
  /// </summary>
  public class PdfDocument : DocumentReader
  {
    public override void InterpretDocumentFormat()
    {
      Console.WriteLine("Document file processed with PDF interpreter");
    }
  }
}
