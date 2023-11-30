public class DataProcessor
{
    private IDataAdapter adapter;

    public void SetAdapter(IDataAdapter newAdapter)
    {
        adapter = newAdapter;
    }

    public DataTemplate ProcessData(DataTemplate source)
    {
        if (adapter == null)
        {
            throw new InvalidOperationException("Adapter is not set.");
        }

        return adapter.Convert(source);
    }
}
