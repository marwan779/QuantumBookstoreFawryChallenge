using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumBookstoreFawryChallenge.Models
{
    public class EBook : BaseBook
    {
        public string FileType { get; set; } = string.Empty;
        public EBook(string iSBN, string title, int publishingYear, double price, string fileType)
            : base(iSBN, title, publishingYear, price)
        {
            FileType = fileType;
        }

        public override void BuyBook(string ISBN, int quantity, string email, string address)
        {
            Console.WriteLine($"The Paid Amount: {Price:C}");
            Console.WriteLine($"Sending EBook to MailService at {email}");
        }
    }
}
