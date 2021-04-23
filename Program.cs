using System;

namespace ClassesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Car RangeRover = new Car();

            RangeRover.Make = "Range Rover";
            RangeRover.Model = "SVAutobiography Dynamic Black Edition";
            RangeRover.Year = "2021";

            Console.WriteLine ($"{RangeRover.Make}\n\r{RangeRover.Model}\n\r{RangeRover.Year}");
            
        }
    }
    

}
