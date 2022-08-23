using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Car : Vehicle
    {
        public Car()
        {

        }
        public Car(string year, string make, string model, bool trunk)
        {
            Year = year;
            Make = make;
            Model = model;
            HasTrunk = trunk;
        }
        public bool HasTrunk { get; set; }

        public string TrunkResponse()
        {
            return HasTrunk ? "is not a" : "is a";
        }
        public override void DriveAbstract()
        {
            Console.WriteLine($"I am driving my {Year}, {Make} {Model} Car. It {TrunkResponse()} hatchback. I love taking it on trips!");
        }

        public void DriveVirtual()
        {
            Console.WriteLine($"I am driving my {Year}, {Make} {Model} Car. It {TrunkResponse()} hatchback. I love taking it on trips!");

        }

    }
}
