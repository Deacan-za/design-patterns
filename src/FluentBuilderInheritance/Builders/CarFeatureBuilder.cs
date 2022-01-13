namespace FluentBuilderInheritance.Builders;

public class CarFeatureBuilder<TSelf> : CarInfoBuilder<CarFeatureBuilder<TSelf>> where TSelf: CarFeatureBuilder<TSelf>
{
  public TSelf SetMostImpressiveFeature(string feature)
  {
    Car.MostImpressiveFeature = feature;
    return (TSelf)this;
  }
}