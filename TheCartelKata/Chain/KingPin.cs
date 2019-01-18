using TheCartelKata.Interface;

namespace TheCartelKata.Chain
{
    public class KingPin : IDistributionLink
    {
        public bool Handled { get; set; }
        public IDistributionLink Next { get; set; }

        public void Handle(double transaction)
        {
            if (transaction > 10000)
            { 
                this.Handled = true;
            }
        }
    }
}
