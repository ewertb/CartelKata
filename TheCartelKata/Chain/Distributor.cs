using System;
using System.Collections.Generic;
using System.Text;
using TheCartelKata.Interface;

namespace TheCartelKata.Chain
{
    public class Distributor : IDistributionLink
    {
        public bool Handled { get; set; }
        public IDistributionLink Next { get; set; }

        public Distributor()
        {
            this.Next = new KingPin();
        }

        public void Handle(double transaction)
        {
            if (transaction > 1000 && transaction <= 10000)
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
