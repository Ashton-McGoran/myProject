using System;

namespace myProject
{
    class Car
    {
        // Private fields
        private string brand;
        private string model;
        private int year;

        // Default constructor
        public Car()
        {
            brand = "Unknown";
            model = "Unknown";
            year = 0;
        }

        // Parameterized constructor
        public Car(string brand, string model, int year)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
        }

        // Get and Set methods
        public string GetBrand()
        {
            return brand;
        }

        public void SetBrand(string brand)
        {
            this.brand = brand;
        }

        public string GetModel()
        {
            return model;
        }

        public void SetModel(string model)
        {
            this.model = model;
        }

        public int GetYear()
        {
            return year;
        }

        public void SetYear(int year)
        {
            this.year = year;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[3]; // Array to hold three Car objects

            // Loop to prompt the user for information for each car
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter information for Car {i + 1}:");
                Console.Write("Enter brand: ");
                string brandInput = Console.ReadLine();
                Console.Write("Enter model: ");
                string modelInput = Console.ReadLine();
                Console.Write("Enter year: ");
                int yearInput = int.Parse(Console.ReadLine());

                // Create car object using parameterized constructor with user input
                cars[i] = new Car(brandInput, modelInput, yearInput);
            }

            // Print out information for each car
            Console.WriteLine("\nInformation for each car:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"\nCar {i + 1}:");
                Console.WriteLine($"Brand: {cars[i].GetBrand()}, Model: {cars[i].GetModel()}, Year: {cars[i].GetYear()}");
            }
        }
    }
}
