using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVC.XSRF.Models;
using MVC.XSRF.Repository;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace XSRF.MVC.Controllers
{
    [Authorize]

    /*if filter is applied globally then this is not required for each and every controller
        [AutoValidateAntiforgeryToken]
    */
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
        /*ignore antiforgery token validation for this action
            [IgnoreAntiforgeryToken]
        */
        public IActionResult Add(Transaction transaction)
        {
            Repository.AddTransaction(transaction);

            return RedirectToAction("Index");
        }
    }
}
