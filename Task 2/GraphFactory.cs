public abstract class GraphFactory
{
    public abstract IGraph CreateGraph();

    public void VisualizeGraph()
    {
        IGraph graph = CreateGraph();
        graph.Draw();
    }
}