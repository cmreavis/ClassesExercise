using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercise1
{
    internal class Car
    {
        public void PrintCarInfo()
        {
            Console.WriteLine($"Model Year: {Year} ");
            Console.WriteLine($"Make: {Make} ");
            Console.WriteLine($"Model: {Model} ");
            Console.WriteLine();
            Console.WriteLine($"{Slogan}");
        }

        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public string ?Slogan { get; set; }
    }
}
