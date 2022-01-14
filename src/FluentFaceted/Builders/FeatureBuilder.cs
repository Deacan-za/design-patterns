using FluentFaceted.Model;

namespace FluentFaceted.Builders;

public class FeatureBuilder : CarBuilder
{
  public FeatureBuilder(Car car)
  {
    Car = car;
  }

  public FeatureBuilder Feature(string feature)
  {
    Car.MostImpressiveFeature = feature;
    return this;
  }

  public FeatureBuilder WithColor(string color)
  {
    Car.Color = color;
    return this;
  }
}