using System;

namespace OOPs.ClassesAndObjects
{
    // 1. Basic class definition for Car
    public class Car
    {
        // Private fields (variables) to hold the data
        private string _make;
        private string _model;
        private int _year;

        // Constructor to initialize the fields
        public Car(string make, string model, int year)
        {
            _make = make;   // Assigning values passed in the constructor to the private fields
            _model = model;
            _year = year;
        }

        // Public method to display the car information
        public void DisplayCarInfo()
        {
            Console.WriteLine($"Car Info: {_make} {_model}, Year: {_year}");
        }

        // Public method to simulate driving the car
        public void Drive()
        {
            Console.WriteLine($"{_make} {_model} is now driving.");
        }
    }

    // 2. Class to run the example
    public class ClassesAndObjectsExample
    {
        public static void RunExample()
        {
            Console.WriteLine("\n--- Basic OOP Example: Classes and Objects ---");

            // Creating an object (instance) of the Car class using the constructor
            Car myCar = new Car("Toyota", "Corolla", 2020);

            // Calling the methods on the object
            myCar.DisplayCarInfo();
            myCar.Drive();
        }
    }
}
