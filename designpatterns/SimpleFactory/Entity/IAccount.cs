namespace SimpleFactory.Entity
{
    public interface IAccount
    {
        decimal Balance { get; set; }
        decimal MakeWithDraw(decimal balance);
        void MakeDeposit(decimal balance);
    }
}
