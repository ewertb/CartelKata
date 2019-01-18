using TheCartelKata.Interface;

namespace TheCartelKata
{
    public class RuralProperty : Property
    {
        public RuralProperty(IDrug drug, double size, double timeUnits, double weightUnits)
            : base(drug, size, timeUnits, weightUnits)
        { }
    }
}
