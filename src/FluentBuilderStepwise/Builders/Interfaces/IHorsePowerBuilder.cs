using FluentBuilderStepwise.Enums;

namespace FluentBuilderStepwise.Builders.Interfaces;

public interface IHorsePowerBuilder
{
  IMaxSpeedBuilder SetHorsePower(CarHorsePower horsePower);
}