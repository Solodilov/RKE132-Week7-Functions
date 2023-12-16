Console.WriteLine("Choose conversion:");
Console.WriteLine("1. Fahrenheit to Celsius");
Console.WriteLine("2. Celsius to Fahrenheit");

int choice = Int32.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.Write("Enter temperature in Fahrenheit: ");
            double fahrenheit = Double.Parse(Console.ReadLine());
            ConvertToCelsius(fahrenheit);
            break;

        case 2:
            Console.Write("Enter temperature in Celsius: ");
            double celsius = Double.Parse(Console.ReadLine());
            ConvertToFahrenheit(celsius);
            break;

        default:
            Console.WriteLine("Invalid choice. Please enter 1 or 2.");
            break;
    }

static void ConvertToCelsius(double fahrenheit)
{
    double celsius = (fahrenheit - 32) * 5 / 9;
    Console.WriteLine($"{fahrenheit} Fahrenheit is equal to {celsius:F2} Celsius.");
}

static void ConvertToFahrenheit(double celsius)
{
    double fahrenheit = (celsius * 9) / 5 + 32;
    Console.WriteLine($"{celsius} Celsius is equal to {fahrenheit:F2} Fahrenheit.");
}