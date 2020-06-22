using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Singleton.Models;

namespace Singleton
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      var name = Policy.Instance.GetInsuredName();
      Console.WriteLine(name);
      Console.ReadLine();
    }
  }
}
