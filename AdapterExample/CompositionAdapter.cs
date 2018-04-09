namespace AdapterExample
{
    public class CompositionAdapter: IHouseBuilder
    {
        private readonly EventRoom _eventRoom;

        public EventRoom EventRoom { get; }

        public CompositionAdapter()
        {
            _eventRoom = new EventRoom();
            EventRoom = _eventRoom;
        }

        public void Build()
        {
            _eventRoom.Decorate();
        }
    }
}