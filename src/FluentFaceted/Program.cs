
using FluentFaceted.Builders;

var builder = new CarBuilder();

var car = builder.HasEngineSpecsOf
    .HorsePower(200)
    .TopSpeed(200)
    .Include
    .Feature("Convertible")
    .WithColor("Red")
    .Build();

Console.WriteLine(car);

