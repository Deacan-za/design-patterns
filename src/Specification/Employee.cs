namespace SpecificationPattern;

internal sealed class Employee
{
  public string Name { get; set; } = null!;

  public EmployeeJobType EmployeeJobType { get; set; }

  public long Salary { get; set; }

  public override string ToString()
  {
    return $"Employee name: {Name} " +
           $"Position: {EmployeeJobType.ToString()} " +
           $"Salary: {Salary}";
  }
}

