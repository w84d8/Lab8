class Program
{
    static void Main()
    {
        Console.WriteLine("Choose a graph type (1 - Line Graph, 2 - Bar Graph, 3 - Pie Chart):");
        int choice = int.Parse(s: Console.ReadLine());

        GraphFactory graphFactory;

        switch (choice)

        {
            case 1:
                graphFactory = new LineGraphFactory();
                break;
            case 2:
                graphFactory = new BarGraphFactory();
                break;
            case 3:
                graphFactory = new PieChartFactory();
                break;
            default:
                throw new InvalidOperationException("Invalid choice");
        }

        var visualizer = new GraphVisualizer(graphFactory);
        object value = visualizer.Visualize();
    }
}