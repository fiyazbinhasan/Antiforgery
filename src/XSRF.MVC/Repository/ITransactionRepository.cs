using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC.XSRF.Models;

namespace MVC.XSRF.Repository
{
    public interface ITransactionRepository
    {
        IEnumerable<Transaction> GetTransactions();
        void AddTransaction(Transaction transaction);
    }
}
