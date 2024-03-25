
using System;

// RentalAgency class to manage the rental agency's fleet of vehicles
public class RentalAgency
{
    // Array to store instances of vehicles
    public Vehicle[] Fleet { get; private set; }

    // Property to track the total revenue earned by the rental agency
    public double TotalRevenue { get; private set; }

    // Constructor
    public RentalAgency(int capacity)
    {
        Fleet = new Vehicle[capacity];
        TotalRevenue = 0;
    }

    // Method to add vehicles to the fleet
    public void AddVehicle(Vehicle vehicle, int index)
    {
        if (index >= 0 && index < Fleet.Length)
        {
            Fleet[index] = vehicle;
        }
        else
        {
            Console.WriteLine("Invalid index. Vehicle could not be added.");
        }
    }

    // Method to remove vehicles from the fleet
    public void RemoveVehicle(int index)
    {
        if (index >= 0 && index < Fleet.Length && Fleet[index] != null)
        {
            Fleet[index] = null;
        }
        else
        {
            Console.WriteLine("Invalid index or no vehicle found at the specified index.");
        }
    }

    // Method to rent a vehicle
    public void RentVehicle(int index)
    {
        if (index >= 0 && index < Fleet.Length && Fleet[index] != null)
        {
            TotalRevenue += Fleet[index].RentalPrice;
            Fleet[index] = null;
            Console.WriteLine("Vehicle rented successfully.");
        }
        else
        {
            Console.WriteLine("Invalid index or no vehicle found at the specified index.");
        }
    }
}








