
using SpecificationPattern;
using SpecificationPattern.Specifications;

List<Employee> employees = new()
{
  new Employee {Name = "Bob", EmployeeJobType = EmployeeJobType.Standard, Salary = 10_000},
  new Employee {Name = "Jane", EmployeeJobType = EmployeeJobType.Standard, Salary = 10_000},
  new Employee {Name = "John", EmployeeJobType = EmployeeJobType.Manager, Salary = 50_000},
  new Employee {Name = "Joe", EmployeeJobType = EmployeeJobType.Manager, Salary = 50_000},
  new Employee {Name = "Jess", EmployeeJobType = EmployeeJobType.Standard, Salary = 10_000},
  new Employee {Name = "Jane", EmployeeJobType = EmployeeJobType.DepartmentHead, Salary = 100_000},
};

var results = employees
  .Filter(new EmployeeJobTypeSpecification(EmployeeJobType.DepartmentHead))
  .Filter(new EmployeeSalarySpecification(10_000));

foreach (var result in results)
{
  Console.WriteLine(result.ToString());
}

Console.ReadKey(true);