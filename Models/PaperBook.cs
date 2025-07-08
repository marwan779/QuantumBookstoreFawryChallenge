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
        public PaperBook(string iSBN, string title, int publishingYear, double price) 
            : base(iSBN, title, publishingYear, price)
        {
        }
    }
}
