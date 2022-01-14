namespace FluentFunctional.Builder;

public static class CarBuilderExtensions
{
  public static CarBuilder AddFeature(this CarBuilder builder, string feature)
    => builder.Do(p => p.MostImpressiveFeature = feature);

}