using TheCartelKata.Interface;

namespace TheCartelKata.Strategy.Storage
{
    public class MdmaStorage : Storage
    {
        public MdmaStorage(IProperty property)
            : base(property, 10)
        { }
    }
}
