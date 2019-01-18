namespace TheCartelKata.Interface
{
    public interface IDistributionLink
    {
        bool Handled { get; set; }
        IDistributionLink Next { get; set; }
        void Handle(double transaction);
    }
}
