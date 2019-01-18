using TheCartelKata.Interface;

namespace TheCartelKata.Strategy.Storage
{
    public class MarijuanaStorage : Storage
    {
        public MarijuanaStorage(IProperty property)
            : base(property, 100)
        { }
    }
}
