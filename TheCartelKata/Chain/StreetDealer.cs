using TheCartelKata.Interface;

namespace TheCartelKata.Chain
{
    public class StreetDealer : IDistributionLink
    {
        public bool Handled { get; set; }
        public IDistributionLink Next { get; set; }

        public StreetDealer()
        {
            this.Next = new Distributor();
        }

        public void Handle(double transaction)
        {
            if (transaction <= 1000)
            {
                this.Handled = true;
            }
            else
            {
                this.Next.Handle(transaction);
            }
        }
    }
}
