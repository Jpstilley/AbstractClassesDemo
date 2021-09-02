using System;
namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public bool HasSideCar { get; set; }

        public Motorcycle()
        {
        }

        public override void DriveAbstract()
        {
            Console.WriteLine("I am driving a motorcycle.\n");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("I turn the throttle to accelerate.\n");
        }

        public override void DisplayCarInfo()
        {
            Console.WriteLine($"A {Year} {Make} {Model} has a sidecar: {HasSideCar}.\n");
        }
    }
}
