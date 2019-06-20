using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Concepts
{
    class Car
    {
        //Data Members
        private string colour;
        private string model;
        private double time;
        private double journeyDistance;

        //Constructor
        public Car(string c, string m, double t, double j)
        {
            colour = c;
            model = m;
            time = t;
            journeyDistance = j;
        }

        //Methods
        public double acceleration()
        {
            return ((2*(journeyDistance))/(time * time));
        }

        public double gForce()
        {
            return acceleration()/ 10;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car Volve = new Car("Red", "Test", 6, 500);
            double acc = Math.Round(Volve.acceleration(), 2);
            double g = Math.Round(Volve.gForce(), 2);
            Console.WriteLine("The acceleration is {0} metres per second, per second", acc);
            Console.WriteLine("The G-Force is {0}g's",g );
        }
    }
}
