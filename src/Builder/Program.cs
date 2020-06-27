using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Builder.Builder;
using Builder.Factory;

namespace Builder
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      var superBuilder = new SuperCarBuilder();
      var lameBuilder = new LameCarBuilder();

      var factory = new CarFactory();
      var builders = new List<CarBuilder>
      {
        superBuilder,
        lameBuilder
      };

      foreach (var builder in builders)
      {
        var c = factory.Build(builder);
        Console.WriteLine($"The car requested by " + 
                          $"{builder.GetType().Name}: " +
                          $"\n-------------------------------------" +
                          $"\nHorse Power: {c.HorsePower} " + 
                          $"\nImpressive Feature: {c.MostImpressiveFeature} " + 
                          $"\nTop Speed: {c.TopSpeedMph}\n");
      }

      Console.ReadLine();
    }
  }
}
