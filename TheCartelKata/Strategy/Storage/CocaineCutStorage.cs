using System.Collections.Generic;
using TheCartelKata.Enum;
using TheCartelKata.Interface;

namespace TheCartelKata.Strategy.Storage
{
    public class CocaineCutStorage : Storage
    {
        private static Dictionary<Cut, double> CutStoragePrice = new Dictionary<Cut, double>
        {
            { Cut.Light, 12000 },
            { Cut.Medium, 14000 },
            { Cut.Heavy, 16000 },
        };

        public CocaineCutStorage(IProperty property)
            : base(property)
        { }

        public override double GetPrice()
        {
            this.Price = CutStoragePrice[this.Property.Drug.Cut];
            return base.GetPrice();
        }
    }
}
