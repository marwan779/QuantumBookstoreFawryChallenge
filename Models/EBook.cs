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
    }
}
