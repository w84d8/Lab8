public class DataPrototype
{
    public virtual DataTemplate Clone()
    {
        return MemberwiseClone() as DataTemplate;
    }
}
