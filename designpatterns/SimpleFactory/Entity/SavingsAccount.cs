using SimpleFactory.Constants;

namespace SimpleFactory.Entity
{
    public class SavingsAccount : IAccount
    {
        public decimal Balance { get; set; }
        public decimal Fees { get; set; }

        public SavingsAccount()
        {
            Fees = GeneralConstants.TAXESFEES;
        }

        public void MakeDeposit(decimal balance)
        {
            Balance += balance;
        }

        public decimal MakeWithDraw(decimal balance)
        {
            Balance -= balance;
            return Balance;
        }

        public void MakeInvestment(decimal balance)
        {
            Balance += balance + Fees;
        }
    }
}
