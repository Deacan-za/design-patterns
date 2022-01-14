using FluentFaceted.Model;

namespace FluentFaceted.Builders;

//Facade wrapping the two internal builders
public class CarBuilder
{
  // reference to object.
  protected Car Car = new();

  public EngineBuilder HasEngineSpecsOf => new(Car);
  public FeatureBuilder Include => new(Car);

  public Car Build() => Car;
}