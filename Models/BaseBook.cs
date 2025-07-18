﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace QuantumBookstoreFawryChallenge.Models
{
    public abstract class BaseBook
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

        public abstract double BuyBook(string ISBN, int quantity, string email, string address);
    }
}
