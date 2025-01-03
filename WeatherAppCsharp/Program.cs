using System;

namespace WeatherAppCsharp
{
    class Program
    {
        // Weather class to hold weather properties
        public class Weather
        {
            public int Temperature { get; set; }
            public string Condition { get; set; } = ""; 
            public int Cloudiness { get; set; }
        }

        static void Main(string[] args)
        {
            // Generate random weather
            Weather weather = GenerateRandomWeather();

            // Display weather details
            DisplayWeather(weather);

            // Check for extreme weather warning
            if (weather.Condition == "Snow" && weather.Temperature < -10)
            {
                Console.ForegroundColor = ConsoleColor.Red; // Set warning text color
                Console.WriteLine("Warning: It's extremely cold and snowy. Do not go outside!");
                Console.ResetColor(); // Reset text color
            }
        }

        // Method to generate random weather
        static Weather GenerateRandomWeather()
        {
            Random random = new Random();

            // Generate random temperature between -10°C and 40°C
            int temperature = random.Next(-10, 41);

            // Randomly select weather condition
            string[] conditions = { "Clear", "Rain", "Snow" };
            string condition = conditions[random.Next(conditions.Length)];

            // Generate random cloudiness percentage (0% - 100%)
            int cloudiness = random.Next(0, 101);

            // Ensure realistic snow temperature
            if (condition == "Snow" && temperature > 5)
            {
                temperature = random.Next(-10, 6); // Restrict temperature for snow between -10°C and 5°C
            }

            return new Weather
            {
                Temperature = temperature,
                Condition = condition,
                Cloudiness = cloudiness
            };
        }

        // Method to display weather details
        static void DisplayWeather(Weather weather)
        {
            Console.WriteLine("Today's Weather:");
            Console.WriteLine($"Temperature: {weather.Temperature}°C");
            Console.WriteLine($"Condition: {weather.Condition}");
            Console.WriteLine($"Cloudiness: {weather.Cloudiness}%");
        }
    }
}
