namespace TheCartelKata.Interface
{
    public interface IStorage
    {
        IProperty Property { get; set; }
        double Price { get; set; }
        double Units { get; set; }
        double GetPrice();
        void Store(double units);
    }
}
