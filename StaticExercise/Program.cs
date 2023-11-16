namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a temperature in Fahrenheit");
            double userInput = double.Parse(Console.ReadLine());
            Console.WriteLine(TempConverter.FahrenheitToCelsius(userInput));
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Enter a temperature in Celsius");
            double usersInput = double.Parse(Console.ReadLine());
            Console.WriteLine(TempConverter.CelsiusToFahrenheit(usersInput));
        }
    }
}
