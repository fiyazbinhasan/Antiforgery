using Microsoft.AspNetCore.Mvc;
using MVC.XSRF.Models;
using MVC.XSRF.Repository;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MVC.XSRF.Controllers
{
    [Authorize]
    [AutoValidateAntiforgeryToken]
    public class TransactionController : Controller
    {
        public ITransactionRepository Repository;
        public TransactionController(ITransactionRepository repository)
        {
            Repository = repository;
        }
        public IActionResult Index()
        {
            var transactions = Repository.GetTransactions();

            return View(transactions);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Transaction transaction)
        {
            Repository.AddTransaction(transaction);

            return RedirectToAction("Index");
        }
    }
}
