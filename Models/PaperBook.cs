using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumBookstoreFawryChallenge.Models
{
    public class PaperBook : BaseBook
    {
        public int Stock {  get; set; }
        public PaperBook(string iSBN, string title, int publishingYear, double price, int stock)
            : base(iSBN, title, publishingYear, price)
        {
            Stock = stock;
        }

        public override void BuyBook(string ISBN, int quantity, string email, string address)
        {
            if (Stock == 0)
                throw new Exception("Error: This Book Is Not Available In The Store !");

            if (quantity > Stock)
                throw new Exception("Error: Not Enough Stock For Paper Book !");

            Stock -= quantity;

            Console.WriteLine($"The Paid Amount: {quantity * Price}");
            Console.WriteLine($"Sending To Shipping Service At {address}");
        }
    }
}
