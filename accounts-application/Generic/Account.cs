namespace accounts_application.Generic
{
    public class Account
    {
        public long AccountId { get; }
        public long Balance { get; set; }

        public Account(long accountId, long balance)
        {
            AccountId = accountId;
            Balance = balance;
        }
    }
}
