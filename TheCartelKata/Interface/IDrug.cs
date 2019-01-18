using TheCartelKata.Enum;

namespace TheCartelKata.Interface
{
    public interface IDrug
    {
        string Name { get; set; }
        Unit Unit { get; set; }
        State State { get; set; }
        Cut Cut { get; set; }
    }
}
