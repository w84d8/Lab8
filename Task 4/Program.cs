class Program
{
    static void Main()
    {
        DataTemplate sampleData = new DataTemplate { Field1 = "Sample", Field2 = 42 };

        DataProcessor dataProcessor = new DataProcessor();

        Console.WriteLine("Choose target format (CSV, XML, JSON): ");
        string targetFormat = Console.ReadLine();

        if (string.IsNullOrEmpty(targetFormat))
        {
            Console.WriteLine("Invalid format. Please choose a valid format.");
            return;
        }

        IDataAdapter adapter = GetDataAdapter(targetFormat);
        dataProcessor.SetAdapter(adapter);

        DataTemplate resultData = dataProcessor.ProcessData(sampleData);

        Console.WriteLine($"Converted data in {targetFormat} format: {resultData.Field1}, {resultData.Field2}");
    }

    static IDataAdapter GetDataAdapter(string format)
    {
        switch (format.ToLower())
        {
            case "csv":
                return new CsvAdapter();
            case "xml":
                return new XmlAdapter();
            case "json":
                return new JsonAdapter();
            default:
                throw new ArgumentException($"Unsupported format: {format}");
        }
    }
}
