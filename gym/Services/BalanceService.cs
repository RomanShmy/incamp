using context;

namespace gym.Services
{
    public class BalanceService
    {
        private ApplicationDbContext _context;

        public BalanceService(ApplicationDbContext context) => this._context = context;

        public Balance GetBalance(int id)
        {
            Balance balance = new Balance();
            decimal bal = 0;
            var transactions = _context.Accounts.Find(id).Transactions;
            foreach (var transaction in transactions)
            {
                bal += transaction.Amount;
            }
            balance.Amount = bal;
            return balance;
        }


        public bool IsPresent(int id)
        {
            if(_context.Accounts.Find(id) == null)
            {
                return false;
            }   
            else
            {
                return true;
            }
        }
    }
}