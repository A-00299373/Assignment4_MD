using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.FeatureManagement;
using GeometryLibrary;

var featureManagement = new Dictionary<string, string> { { "FeatureManagement:Square", "false" }, { "FeatureManagement:Rectangle", "true" }, { "FeatureManagement:Triangle", "true" } };

IConfigurationRoot configuration = new ConfigurationBuilder().AddInMemoryCollection(featureManagement).Build();

var services = new ServiceCollection();
services.AddFeatureManagement(configuration);
var serviceProvider = services.BuildServiceProvider();

var featureManager = serviceProvider.GetRequiredService<IFeatureManagerSnapshot>();

Console.WriteLine("Choose the shape:");
Console.WriteLine("1.Square");
Console.WriteLine("2.Rectangle");
Console.WriteLine("3.Triangle");

var s = Console.ReadLine();

switch (s)
{
    case "1":

        if (await featureManager.IsEnabledAsync("Square"))
        {
            Console.WriteLine("You have chosen Square and it's enabled.");

            Console.WriteLine("Enter the length of the square:");
            int length = int.Parse(Console.ReadLine() ?? string.Empty);

            var square = new Square(length);
            Console.WriteLine($"Area of the square: {square.CalculateArea()}");
            Console.WriteLine($"Perimeter of the square: {square.CalculatePerimeter()}");
        }
        else
        {
            Console.WriteLine("Square is disabled.");
        }
        break;

    case "2":
        if (await featureManager.IsEnabledAsync("Rectangle"))
        {
            Console.WriteLine("You have chosen Rectangle and it's enabled.");

            Console.WriteLine("Enter the length of the rectangle:");
            double length = double.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine("Enter the width of the rectangle:");
            double width = double.Parse(Console.ReadLine() ?? string.Empty);

            var rectangle = new Rectangle(length, width);

            Console.WriteLine($"Area of the rectangle: {rectangle.CalculateArea()}");
            Console.WriteLine($"Perimeter of the rectangle: {rectangle.CalculatePerimeter()}");
        }
        else
        {
            Console.WriteLine("Rectangle is disabled.");
        }
        break;

    case "3":
        Console.WriteLine("You have chosen Triangle");
        if (await featureManager.IsEnabledAsync("Triangle"))
        {
            Console.WriteLine("You have chosen Triangle and it's enabled.");

            Console.WriteLine("Enter the base length of the triangle:");
            double baseLength = double.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine("Enter the height of the triangle:");
            double height = double.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine("Enter the length of side A of the triangle:");
            double sideA = double.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine("Enter the length of side B of the triangle:");
            double sideB = double.Parse(Console.ReadLine() ?? string.Empty);

            var triangle = new Triangle(baseLength, height, sideA, sideB);

            Console.WriteLine($"Area of the triangle: {triangle.CalculateArea()}");
            Console.WriteLine($"Perimeter of the triangle: {triangle.CalculatePerimeter()}");
        }
        else
        {
            Console.WriteLine("Triangle is disabled.");
        }
        break;

    default:
        Console.WriteLine("Wrong choice");
        break;
}
