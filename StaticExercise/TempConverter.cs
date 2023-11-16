using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    internal static class TempConverter
    {
        public static double FahrenheitToCelsius(double ftemperature)
        {
            // C = (F-32) * 5 / 9; 
            return (ftemperature - 32) * 5 / 9; 
        }

        public static double CelsiusToFahrenheit(double ctemperature)
        {
            return (ctemperature * 9) / 5 + 32; 
        }
    }
}
