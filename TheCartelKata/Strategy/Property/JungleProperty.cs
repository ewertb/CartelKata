using TheCartelKata.Interface;

namespace TheCartelKata
{
    public class JungleProperty : Property
    {
        public JungleProperty(IDrug drug, double size, double timeUnits, double weightUnits)
            : base(drug, size, timeUnits, weightUnits)
        { }
    }
}
