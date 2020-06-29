namespace Composite.Models
{
  // IComponent interface.
  public interface IEmployee
  {
    int EmployeeId { get; set; }
    string Name { get; set; }
    int Rating { get; set; }
    void PerformanceSummary();
  }
}
