namespace accounts_application.Exceptions
{
    public class WithdrawalAmountTooLargeException : Exception
    {
        public WithdrawalAmountTooLargeException(string message) : base(message) { }
    }
}
