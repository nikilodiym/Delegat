using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegats
{
    public class Task3
    {
        public class CreditCard
        {
            public string CardNumber { get; set; }
            public string OwnerName { get; set; }
            public DateTime ExpiryDate { get; set; }
            public string PIN { get; set; }
            public decimal CreditLimit { get; set; }
            public decimal Balance { get; set; }

            public event Action<decimal> AccountReplenished;
            public event Action<decimal> MoneySpent;
            public event Action CreditStarted;
            public event Action<decimal> LimitReached;
            public event Action<string> PINChanged;

            public void ReplenishAccount(decimal amount)
            {
                Balance += amount;
                AccountReplenished?.Invoke(amount);
            }

            public void SpendMoney(decimal amount)
            {
                if (Balance >= amount)
                {
                    Balance -= amount;
                    MoneySpent?.Invoke(amount);
                }
            }

            public void StartCredit()
            {
                CreditStarted?.Invoke();
            }

            public void CheckLimit(decimal amount)
            {
                if (Balance + amount > CreditLimit)
                {
                    LimitReached?.Invoke(amount);
                }
            }

            public void ChangePIN(string newPIN)
            {
                PIN = newPIN;
                PINChanged?.Invoke(newPIN);
            }
        }
    }
}
