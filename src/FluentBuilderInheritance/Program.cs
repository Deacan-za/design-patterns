
using FluentBuilderInheritance.Models;


var car = Car.New
  .SetHorsePower(200)
  .SetTopSpeed(200)
  .SetMostImpressiveFeature("Racing Red")
  .Build();

Console.WriteLine(car);


