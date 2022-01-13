using FluentBuilderInheritance.Builders;

namespace FluentBuilderInheritance.Models
{
  public class Car
  {
    public int TopSpeedMph { get; set; }
    public int HorsePower { get; set; }
    public string MostImpressiveFeature { get; set; } = string.Empty;

    public class Builder : CarBuilder<Builder>
    {
    }

    public static Builder New => new Builder();

    public override string ToString()
    {
      return $"{nameof(TopSpeedMph)}: {TopSpeedMph}mph, {nameof(HorsePower)}: {HorsePower}, {nameof(MostImpressiveFeature)}: {MostImpressiveFeature}";
    }
  }
}
