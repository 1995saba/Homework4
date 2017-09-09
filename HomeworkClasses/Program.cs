using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 5;
            Rocket[] rockets = new Rocket[size];

            for (int i=0; i<size;i++ )
            {
                rockets[i] = new Rocket();
            }

            Rocket.NumberOfRockets();
            Console.ReadLine();
        }
    }
}
