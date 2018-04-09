namespace AdapterExample
{
    public class InheritanceAdapter : EventRoom, IHouseBuilder
    {
        public void Build()
        {
            Decorate();
        }
    }
}