using System;

namespace ConstructorInheritance
{
    public class Vehicle
    {
        private readonly string _registrationNumber;

    
        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            Console.WriteLine("Vehicle is being Initialized. {0}", registrationNumber);
        }
        
    }
}