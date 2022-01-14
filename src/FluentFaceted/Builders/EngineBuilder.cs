using FluentFaceted.Model;

namespace FluentFaceted.Builders;

public class EngineBuilder : CarBuilder
{
  public EngineBuilder(Car car)
  {
    Car = car;
  }

  public EngineBuilder HorsePower(int horses)
  {
    Car.HorsePower = horses;
    return this;
  }

  public EngineBuilder TopSpeed(int speed)
  {
    Car.TopSpeedMph = speed;
    return this;
  }
}