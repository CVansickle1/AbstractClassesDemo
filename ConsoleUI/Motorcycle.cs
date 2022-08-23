using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public Motorcycle()
        {

        }
        public Motorcycle(string year, string make, string model, bool sideCar)
        {
            Year = year;
            Make = make;
            Model = model;
            HasSideCar = sideCar;
        }
        public bool HasSideCar { get; set; }

        public string SideCarResponse()
        {
            return HasSideCar ? "does" : "does not";
        }

        public override void DriveAbstract()
        {
            Console.WriteLine( $"I am driving my {Year}, {Make} {Model} Motorcycle. It {SideCarResponse()} have a side car. Its Pretty Cool!");
        }

        public void DriveVirtual()
        {
            Console.WriteLine($"I am driving my {Year}, {Make} {Model} Motorcycle. It {SideCarResponse()} have a side car. Its Pretty Cool!");
        }
    }
}
