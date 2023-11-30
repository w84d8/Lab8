internal class Program
{
    private static void Main()
    {
        Console.WriteLine("Choose a product type (1. Smartphone, 2. Laptop, 3. Tablet):");
        string choice = Console.ReadLine();

        ITechnologyFactory factory = GetFactory(choice);

        if (factory != null)
        {
            IScreen screen = factory.CreateScreen();
            IProcessor processor = factory.CreateProcessor();
            ICamera camera = factory.CreateCamera();

            Console.WriteLine($"Screen: {screen.GetDescription()}");
            Console.WriteLine($"Processor: {processor.GetDescription()}");
            Console.WriteLine($"Camera: {camera.GetDescription()}");
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }

    private static ITechnologyFactory GetFactory(string choice)
    {
        switch (choice)
        {
            case "1":
                return new SmartphoneFactory();
            default:
                return null;
        }
    }
}