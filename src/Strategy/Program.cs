using System;
using Strategy.Context;
using Strategy.Strategies;

namespace Strategy
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      var students = new SortedList();
      students.Add("Ronnie");
      students.Add("Bobby");
      students.Add("Kate");
      students.Add("Mike");
      students.Add("Ricky");

      students.SetSortStrategy(new QuickSort());
      students.Sort();

      students.SetSortStrategy(new ShellSort());
      students.Sort();

      students.SetSortStrategy(new MergeSort());
      students.Sort();

      Console.ReadKey();
    }
  }
}
