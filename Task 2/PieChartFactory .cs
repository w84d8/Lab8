public class PieChartFactory : GraphFactory
{
    public override IGraph CreateGraph()
    {
        return new PieChart();
    }
}