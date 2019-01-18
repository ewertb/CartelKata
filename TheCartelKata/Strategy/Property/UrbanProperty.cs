using TheCartelKata.Interface;

namespace TheCartelKata
{
    public class UrbanProperty : Property
    {
        public UrbanProperty(IDrug drug, double size, double timeUnits, double weightUnits)
            : base(drug, size, timeUnits, weightUnits)
        { }
    }
}
