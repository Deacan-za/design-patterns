using FluentBuilderStepwise.Models;

namespace FluentBuilderStepwise.Builders.Interfaces;

public interface IBuilder
{
  IBuilder SetFeature(string feature);
  Car Build();
}