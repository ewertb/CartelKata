using TheCartelKata.Interface;

namespace TheCartelKata.Strategy.Storage
{
    public class CocaineRawStorage : Storage
    {
        public CocaineRawStorage(IProperty property)
            : base(property, 10000)
        { }
    }
}
