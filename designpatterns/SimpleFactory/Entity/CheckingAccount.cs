namespace SimpleFactory.Entity
{
    public class CheckingAccount : IAccount
    {
        public decimal Balance { get; set; }

        public void MakeDeposit(decimal balance)
        {
            Balance += balance;
        }

        public decimal MakeWithDraw(decimal balance)
        {
            Balance -= balance;
            return Balance;
        }

    }
}
