using System.Collections.Generic;
using Angular.Asp.Net.Core.XSRF.RC2.Models;
using Angular.Asp.Net.Core.XSRF.RC2.Repository;
using Microsoft.AspNetCore.Mvc;

namespace XSRF.ANGULAR.Controllers
{
    [Route("api/[controller]")]
    public class TransactionController : Controller
    {
        public ITransactionRepository Repository;

        public TransactionController(ITransactionRepository repository)
        {
            Repository = repository;
        }
        [HttpGet]
        public IEnumerable<Transaction> Get()
        {
            return Repository.GetTransactions();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public void Post([FromBody]Transaction transaction)
        {
            Repository.AddTransaction(transaction);
        }
    }
}
