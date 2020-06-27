using Builder.Models;

namespace Builder.Builder
{
  public abstract class CarBuilder
  {
    protected readonly Car Car = new Car();
    public abstract void SetHorsePower();
    public abstract void SetTopSpeed();
    public abstract void SetMostImpressiveFeature();

    public virtual Car GetCar()
    {
      return Car;
    }
  }
}
