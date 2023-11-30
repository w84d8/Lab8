using System;

public class ConfigurationManager
{
    private static ConfigurationManager? instance;
    private string environmentSetting;

    private ConfigurationManager()
    {
        environmentSetting = "Production";
    }

    public static ConfigurationManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new ConfigurationManager();
            }
            return instance;
        }
    }

    internal class ConsoleWrapper
    {
        public string ReadLine()
        {
            return Console.ReadLine() ?? string.Empty;
        }
    }

    public string EnvironmentSetting
    {
        get { return environmentSetting; }
        set
        {
            environmentSetting = value;
            Console.WriteLine($"Environment setting changed to: {environmentSetting}");
        }
    }

}
