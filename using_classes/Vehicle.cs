using System;

namespace using_classes
{
    public class Vehicle
    {
        private readonly string registrationNumber;

        public Vehicle(string registrationNumber)
        {
            this.registrationNumber = registrationNumber;
            Console.WriteLine("Vehicle bein initialized. With registration number {0}", this.registrationNumber);
        }
    }
}
