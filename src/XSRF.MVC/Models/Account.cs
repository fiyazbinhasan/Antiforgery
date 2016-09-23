using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVC.XSRF.Models
{
    public class Account
    {
        [Display(Name = "Acc. no")]
        public string AccountNumber { get; set; }

        [Display(Name = "Balance")]
        public decimal CurrentBalance { get; set; }
    }
}
