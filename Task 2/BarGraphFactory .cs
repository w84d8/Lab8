public class BarGraphFactory : GraphFactory
{
    public override IGraph CreateGraph()
    {
        return new BarGraph();
    }
}