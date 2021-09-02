using System;
namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public bool HasTrunk { get; set; }

        public Car()
        {
        }

        public override void DriveAbstract()
        {
            Console.WriteLine("I am driving a car.\n");
        }

        public override void DisplayCarInfo()
        {
            Console.WriteLine($"A {Year} {Make} {Model} has a trunk: {HasTrunk}.\n");
        }
    }
}
