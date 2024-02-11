using accounts_application.Generic;

namespace accounts_application.Savings
{
    public class SavingsAccount : Account
    {
        public SavingsAccount(long accountId, long amountToDeposit) : base(accountId, amountToDeposit)
        {
            if (amountToDeposit < 1000)
            {
                throw new ArgumentException("Minimum deposit for savings account is R1000.");
            }
        }

        public void Withdraw(int amount)
        {
            if (Balance - amount < 1000)
            {
                throw new ArgumentException("Minimum deposit for savings account is R1000.");
            }
            Balance -= amount;
        }

        public void Deposit(int amount)
        {
            Balance += amount;
        }
    }
}
