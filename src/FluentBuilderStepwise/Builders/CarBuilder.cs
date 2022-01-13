using FluentBuilderStepwise.Builders.Interfaces;
using FluentBuilderStepwise.Enums;
using FluentBuilderStepwise.Models;

namespace FluentBuilderStepwise.Builders;

public class CarBuilder
{
  private class Impl :
    IHorsePowerBuilder,
    IMaxSpeedBuilder,
    IBuilder
  {
    private readonly Car _car = new();

    public IMaxSpeedBuilder SetHorsePower(CarHorsePower horsePower)
    {
      _car.HorsePower = (int)horsePower;
      return this;
    }

    public IBuilder SetMaxSpeed()
    {
      _car.TopSpeedMph = _car.HorsePower switch
      {
        (int)CarHorsePower.FiftyHorses => (int)CarMaxSpeed.FiftyMph,
        (int)CarHorsePower.OneHundredHorses => (int)CarMaxSpeed.OneHundredMph,
        (int)CarHorsePower.TwoHundredHorses => (int)CarMaxSpeed.TwoHundredMph,
        _ => 0
      };

      return this;
    }

    public Car Build()
    {
      return _car;
    }

    public IBuilder SetFeature(string feature)
    {
      _car.MostImpressiveFeature = feature;
      return this;
    }
  }

  public static IHorsePowerBuilder Create()
  {
    return new Impl();
  }
}