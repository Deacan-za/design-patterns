using FluentFunctional.Model;

namespace FluentFunctional.Builder;

public class CarBuilder : FunctionalBuilder<Car, CarBuilder>
{
  public CarBuilder AddTopSpeed(int speed) => Do(p => p.TopSpeedMph = speed);
  public CarBuilder AddHorsePower(int horses) => Do(p => p.HorsePower = horses);
}