using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumBookstoreFawryChallenge.Models
{
    public class DemoBook : BaseBook
    {
        public DemoBook(string iSBN, string title, int publishingYear, double price) 
            : base(iSBN, title, publishingYear, price)
        {
        }

        public override void BuyBook(string ISBN, int quantity, string email, string address)
        {
            throw new NotImplementedException("Demo books are not for sale !");
        }
    }
}
