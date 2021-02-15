using System;

namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
            

        {
            string userOption = null;
            do
            {
                Console.WriteLine("What conversion would you like to perform? FtoC or CtoF?");
                userOption = Console.ReadLine().ToLower();
                if (userOption == "ftoc")
                {

                }

                Console.WriteLine("What is the temperature in Fahrenheit you want to convert to Celsius?");
                double fahTemp = Convert.ToDouble(Console.ReadLine());

                double convertToCel = TempConverter.FahrenheitToCelsius(fahTemp);

                Console.WriteLine($"{fahTemp} is {convertToCel} degrees Celsius");

                Console.WriteLine();
                Console.WriteLine($"{fahTemp} is {convertToCel} degrees Celsius");
            }

            
        }
    }
}
