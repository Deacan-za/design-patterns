namespace SpecificationPattern.Specifications;

internal interface ISpecification<in T> where T : class
{
  bool IsSatisfied(T candidate);
}