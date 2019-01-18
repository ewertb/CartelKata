using TheCartelKata.Factory;
using TheCartelKata.Interface;

namespace TheCartelKata
{
    public class Property : IProperty
    {
        public IDrug Drug { get; set; }
        public double Size { get; set; }
        public double TimeUnits { get; set; }
        public double WeightUnits { get; set; }
        public IStorage Storage { get; set; }

        public Property(IDrug drug, double size, double timeUnits, double weightUnits)
        {
            this.Drug = drug;
            this.Size = size;
            this.TimeUnits = timeUnits;
            this.WeightUnits = weightUnits;
            this.Storage = StorageFactory.Storage[drug.GetType()](this);
        }

        public virtual void Produce(double days)
        {
            var time = days / this.TimeUnits;
            var weight = this.WeightUnits * time;
            this.Storage.Units = this.Size * weight;
        }
    }
}
