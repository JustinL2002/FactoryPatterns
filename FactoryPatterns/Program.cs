
using FactoryPatterns;

Console.WriteLine("enter number of tires");
int numberOfTires = int.Parse(Console.ReadLine());
var myVehicle = VehicleFactory.Vehicle(numberOfTires);
myVehicle.Drive();