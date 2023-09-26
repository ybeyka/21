using System;
using System.Collections.Generic;
using System.Linq;

public class Car
{
    public string Model { get; set; }
    public string Make { get; set; }
    public decimal Price { get; set; }
}

class Program
{
    static void Main()
    {
         List<Car> cars = new List<Car>
        {
            new Car { Make = "Toyota", Model = "Camry", Price = 24000m },
            new Car { Make = "Honda", Model = "Accord", Price = 22500m },
            new Car { Make = "Tesla", Model = "Model 3", Price = 35000m },
            new Car { Make = "Ford", Model = "Fusion", Price = 20000m }
        };

        var sortedCars = from car in cars
                         orderby car.Price
                         select car;

        Console.WriteLine("Cars sorted by Price:");
        foreach (var car in sortedCars)
        {
            Console.WriteLine($"{car.Make} {car.Model} - ${car.Price}");
        }
    }
}
