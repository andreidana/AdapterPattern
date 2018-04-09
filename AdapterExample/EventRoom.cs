namespace AdapterExample
{
    public class EventRoom
    {
        public bool Decorated { get; private set; }

        public void Decorate()
        {
            Decorated = true;
        }
    }
}