using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVC.XSRF.Models
{
    public class Transaction
    {
        [Display(Name = "Amount")]
        public decimal TransactionAmount { get; set; }

        [Display(Name = "Type")]
        public string TransactionType { get; set; }
        public Account Account { get; set; }
    }
}
