namespace Rebar.Classes
{
    public class Account
    {
        private List<Account> _accounts;
        private double _sumPrice;
        private List<Account> Accounts { get; set; }
        public double SumPrice { get; }
        public Account(List<Account> accounts)
        {
            this._accounts = accounts;
            foreach (var account in accounts)
            {
                this.SumPrice += account.SumPrice;
            }
        }
    }
}
