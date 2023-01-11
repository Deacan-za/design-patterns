namespace SpecificationPattern.Specifications;

internal sealed class EmployeeSalarySpecification : ISpecification<Employee>
{
  private readonly long _salary;

  public EmployeeSalarySpecification(long salary)
  {
    _salary = salary;
  }

  public bool IsSatisfied(Employee candidate)
  {
    return candidate.Salary >= _salary;
  }
}