using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_1_Satya
{

    class Car
    {
        public string Name(string name)
        {
            return name;
        }
        public int Year(int year)
        {
            return year;
        }

    }



    internal class problem3
    {
        static void Main()
        {
            Car car = new Car();
            Console.WriteLine("Enter car model name:");
            car.Name(Console.ReadLine());
            Console.WriteLine("Enter year of model:");
            car.Year(Console.ReadLine());
        }
    }
}
