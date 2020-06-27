namespace Builder.Builder
{
  public class LameCarBuilder: CarBuilder
  {
    public override void SetHorsePower()
    {
      Car.HorsePower = 120;
    }

    public override void SetTopSpeed()
    {
      Car.TopSpeedMph = 70;
    }

    public override void SetMostImpressiveFeature()
    {
      Car.MostImpressiveFeature = "Has air con";
    }
  }
}
