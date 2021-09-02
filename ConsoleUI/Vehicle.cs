using System;
namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Year { get; set; } = "Year Created";
        public string Make { get; set; } = "Manufacturer";
        public string Model { get; set; } = "Model";


        public Vehicle()
        {
           
        }

        public abstract void DriveAbstract();

        public abstract void DisplayCarInfo();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("I am driving virtually.\n");
        }


        /*
        * Create an abstract class called Vehicle
        * The vehicle class shall have three string properties Year, Make, and Model
        * Set the defaults to something generic in the Vehicle class
        * Vehicle shall have an abstract method called DriveAbstract with no implementation
        * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
        */
    }
}
