namespace TheCartelKata.Interface
{
    public interface IProperty
    {
        IDrug Drug { get; set; }
        double Size { get; set; }
        double TimeUnits { get; set; }
        double WeightUnits { get; set; }
        IStorage Storage { get; set; }
        void Produce(double days);
    }
}
