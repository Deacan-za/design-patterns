namespace Builder.Builder
{
  public class SuperCarBuilder: CarBuilder
  {
    public override void SetHorsePower()
    {
      Car.HorsePower = 1640;
    }

    public override void SetTopSpeed()
    {
      Car.TopSpeedMph = 600;
    }

    public override void SetMostImpressiveFeature()
    {
      Car.MostImpressiveFeature = "Can Fly";
    }
  }
}
