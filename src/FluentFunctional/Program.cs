// See https://aka.ms/new-console-template for more information

using FluentFunctional.Builder;

var car = new CarBuilder().AddHorsePower(200).AddTopSpeed(200).AddFeature("Racing Red").Build();

Console.WriteLine(car);
