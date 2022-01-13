

using FluentBuilder.Builder;

var builder = new CarBuilder();
var car = builder.SetHorsePower(200).SetTopSpeed(200).SetMostImpressiveFeature("Racing Red").Build();


Console.WriteLine(car);
