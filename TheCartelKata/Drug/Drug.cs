using TheCartelKata.Enum;
using TheCartelKata.Interface;

namespace TheCartelKata
{
    public abstract class Drug : IDrug
    {
        public string Name { get; set; }
        public Unit Unit { get; set; }
        public State State { get; set; }
        public Cut Cut { get; set; }
        public Drug(string name, Unit unit)
        {
            this.Name = name;
            this.Unit = unit;
        }
    }
}
