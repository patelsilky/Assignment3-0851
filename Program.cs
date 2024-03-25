
using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating instances of vehicles
        Car car = new Car("Civic", "Honda", 2022, 50, 5, "Petrol", "Automatic", false);
        Truck truck = new Truck("F-150", "Ford", 2020, 100, 2.5, "Pickup", true);
        Motorcycle motorcycle = new Motorcycle("Ninja", "Kawasaki", 2021, 30, 1000, "Petrol", true);

        // Displaying details of each vehicle
        Console.WriteLine("Car Details:");
        car.DisplayDetails();
        Console.WriteLine();

        Console.WriteLine("Truck Details:");
        truck.DisplayDetails();
        Console.WriteLine();

        Console.WriteLine("Motorcycle Details:");
        motorcycle.DisplayDetails();
        Console.WriteLine();

        // Creating a rental agency
        RentalAgency rentalAgency = new RentalAgency(10);

        // Adding vehicles to the rental agency's fleet
        rentalAgency.AddVehicle(car, 0);
        rentalAgency.AddVehicle(truck, 1);
        rentalAgency.AddVehicle(motorcycle, 2);

        // Renting a vehicle
        rentalAgency.RentVehicle(0);

        // Displaying updated fleet and total revenue
        Console.WriteLine("\n--- Fleet after renting a vehicle ---");
        for (int i = 0; i < rentalAgency.Fleet.Length; i++)
        {
            if (rentalAgency.Fleet[i] != null)
            {
                Console.WriteLine($"Vehicle at index {i}: {rentalAgency.Fleet[i].Model}");
            }
            else
            {
                Console.WriteLine($"No vehicle at index {i}");
            }
        }
        Console.WriteLine($"Total Revenue: ${rentalAgency.TotalRevenue}");
    }
}


