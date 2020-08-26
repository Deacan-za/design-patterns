using System;
using Template.Templates;

namespace Template
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      Console.WriteLine("---- Document Reader - PDF ----");
      var pdfReader = new PdfDocument();
      pdfReader.OpenDocument();


      Console.WriteLine("---- Document Reader - RTF ----");
      var rtfReader = new RtfDocument();
      rtfReader.OpenDocument();

      Console.ReadKey();
    }
  }
}
