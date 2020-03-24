using System;
using System.Collections.Generic;
using System.Text;

namespace Intermediate_Practice_Udemy_Course
{
    class Vehicle
    {
        private readonly string _registrationNumber;

/*        public Vehicle()
        {
            Console.WriteLine("vehicle is being initialied.");
        }*/

        public Vehicle(string registrationNumber)
        {
            this._registrationNumber = registrationNumber;
            Console.WriteLine("Vehicle is being initialized. {0}", registrationNumber);
        }
    }
}
