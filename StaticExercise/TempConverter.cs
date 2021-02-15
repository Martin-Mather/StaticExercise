using System;
namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double fTemp)
        {
            var celTemp = ((fTemp - 32)) / 1.8;

            return celTemp;
        }

        public static double CelsiusToFahrenheit(double cTemp)
        {
            var fahTemp = ((cTemp * 1.8) + 32);
            return fahTemp;
        }
    }
}
