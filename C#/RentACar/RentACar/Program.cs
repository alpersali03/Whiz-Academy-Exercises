using RentACar;

RebtalCar car = new RebtalCar();
car.RentCar();
Console.WriteLine(car.IsRented ? "rented" : "free");
car.ReturnCar();
Console.WriteLine($"The condition of the car is: {car.IsRented}");