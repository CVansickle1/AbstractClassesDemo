using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    abstract class Vehicle
    {
        public Vehicle()
        {

        }
        public Vehicle(string year, string make, string model)
        {
            Year = year;
            Make = make;
            Model = model;
            
        }

        public string Year { get; set; } = "0000";

        public string Make { get; set; } = "Unknown";

        public string Model { get; set; } = "Unknown";

        public string Type { get; set; } = "Unknown";

        abstract public void DriveAbstract();
        
        virtual public void DriveVirtual()
        {
            Console.WriteLine($"I am driving my {Year}, {Make} {Model}. Its a {Type}. Its Awesome!");
        }
        
        
    }
}
