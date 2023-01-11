namespace SpecificationPattern.Specifications;

internal sealed class EmployeeJobTypeSpecification : ISpecification<Employee>
{
  private readonly EmployeeJobType _employeeJobType;

  public EmployeeJobTypeSpecification(EmployeeJobType employeeJobType)
  {
    _employeeJobType = employeeJobType;
  }

  public bool IsSatisfied(Employee candidate)
  {
    return candidate.EmployeeJobType == _employeeJobType;
  }
}