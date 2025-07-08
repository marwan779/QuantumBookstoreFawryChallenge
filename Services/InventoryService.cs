using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuantumBookstoreFawryChallenge.Models;

namespace QuantumBookstoreFawryChallenge.Services
{
    public class InventoryService
    {
        private List<BaseBook> booksInventory = new List<BaseBook>();


        public void AddBook(BaseBook book)
        {
            booksInventory.Add(book);
            Console.WriteLine("The Book Is Added Successfully");
        }

        public List<BaseBook> RemoveOutdatedBooks(int year)
        {
            List<BaseBook> outdatedBooks = new List<BaseBook>();

            int currentYear = DateTime.Now.Year;

            outdatedBooks = booksInventory.Where(b => currentYear - b.PublishingYear  >  year).ToList();

            foreach (BaseBook book in outdatedBooks)
            {
                outdatedBooks.Remove(book);
            }    

            return outdatedBooks;
        }

        public double PurchaseBook(string ISBN, int quantity, string email, string address)
        {
            BaseBook? book = booksInventory.FirstOrDefault(b => b.ISBN == ISBN);

            if (book == null)
            {
                throw new Exception("Now Such Book In The Inventory");
            }

            double amount = book.BuyBook(ISBN, quantity, email, address);

            return amount;
        }
    }
}
