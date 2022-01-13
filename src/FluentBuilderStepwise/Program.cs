// Requirement:
// Car object can only be created in an certain order because we need to know the 
// horse power in order to set the max speed.

using FluentBuilderStepwise.Builders;
using FluentBuilderStepwise.Enums;

var car1 = CarBuilder.Create().SetHorsePower(CarHorsePower.FiftyHorses).SetMaxSpeed().SetFeature("Convertible").Build();
var car2 = CarBuilder.Create().SetHorsePower(CarHorsePower.OneHundredHorses).SetMaxSpeed().Build();
var car3 = CarBuilder.Create().SetHorsePower(CarHorsePower.TwoHundredHorses).SetMaxSpeed().SetFeature("Racing Red").Build();


Console.WriteLine(car1);
Console.WriteLine(car2);
Console.WriteLine(car3);