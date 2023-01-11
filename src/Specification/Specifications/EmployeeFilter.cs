namespace SpecificationPattern.Specifications;

internal static class EmployeeFilter
{
  public static List<Employee> Filter(this IEnumerable<Employee> employees, ISpecification<Employee> spec)
  {
    return employees.Where(spec.IsSatisfied).ToList();
  }
}