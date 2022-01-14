namespace FluentFaceted.Model;

public class Car
{
  //Engine Specs
  public int TopSpeedMph { get; set; }
  public int HorsePower { get; set; }

  //Features
  public string MostImpressiveFeature { get; set; } = string.Empty;
  public string Color { get; set; } = string.Empty;


  public override string ToString()
  {
    return $"{nameof(TopSpeedMph)}: {TopSpeedMph}mph," +
           $" {nameof(HorsePower)}: {HorsePower}," +
           $" {nameof(MostImpressiveFeature)}: {MostImpressiveFeature}," + 
           $" {nameof(Color)}: {Color}";
  }
}