using TheCartelKata.Interface;

namespace TheCartelKata.Strategy.Storage
{
    public class Storage : IStorage
    {
        public IProperty Property { get; set; }
        public double Price { get; set; }
        public double Units { get; set; }
        public Storage(IProperty property)
        {
            this.Property = property;
        }
        public Storage(IProperty property, double price)
        {
            this.Property = property;
            this.Price = price;
        }
        public virtual double GetPrice()
        {
            return this.Price * this.Units;
        }
        public void Store(double units)
        {
            this.Units = units;
        }
    }
}
