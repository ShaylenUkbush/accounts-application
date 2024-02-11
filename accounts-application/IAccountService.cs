namespace accounts_application
{
    public interface IAccountService
    {
        void openSavingsAccount(long accountId, long amountToDeposit);
        void openCurrentAccount(long accountId);
        void withdraw(long accountId, int amountToWithdraw);
        void deposit(long accountId, int amountToDeposit);
    }
}
