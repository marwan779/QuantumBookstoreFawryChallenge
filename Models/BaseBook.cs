using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantumBookstoreFawryChallenge.Models
{
    public class BaseBook
    {
        public string ISBN { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public int PublishingYear { get; set; }
        public double Price { get; set; }

        public BaseBook(string iSBN, string title, int publishingYear, double price)
        {
            ISBN = iSBN;
            Title = title;
            PublishingYear = publishingYear;
            Price = price;
        }
    }
}
