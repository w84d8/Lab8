internal class Program
{
    private static void Main(string[] args)
    {
        ConfigurationManager configManager = ConfigurationManager.Instance;
        ConsoleWrapper console = new ConsoleWrapper();

        Console.WriteLine($"Current environment setting: {configManager.EnvironmentSetting ?? "Not set"}");

        Console.Write("Enter a new environment setting: ");
        string newSetting = console.ReadLine();
        configManager.EnvironmentSetting = newSetting;

        Console.WriteLine($"Updated environment setting: {configManager.EnvironmentSetting ?? "Not set"}");
    }
}

internal class ConsoleWrapper
{
    public string ReadLine()
    {
        return Console.ReadLine();
    }
}
