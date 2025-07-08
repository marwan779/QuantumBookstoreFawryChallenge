using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuantumBookstoreFawryChallenge.Models;
using QuantumBookstoreFawryChallenge.Services;

namespace QuantumBookstoreFawryChallenge.Testing
{
    public static class TestCases
    {

        public static void TestAddBooks(InventoryService inventoryService)
        {
            inventoryService.AddBook(new PaperBook("001", "C# Basics", 2020, 50, 10));
            inventoryService.AddBook(new EBook("002", "Learn LINQ", 2022, 30, "pdf"));
            inventoryService.AddBook(new DemoBook("003", "Intro to .NET", 2017, 0));

            Console.WriteLine();
        }

        public static void TestBuyPaperBook(InventoryService inventoryService)
        {

            try
            {
                double paid = inventoryService.PurchaseBook("001", 2, "user@example.com", "123 Main St");
                
                Console.WriteLine($"Quantum book store: Paid Amount = {paid:C}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();
        }

        public static void TestBuyEBook(InventoryService inventoryService)
        {
            try
            {
                inventoryService.PurchaseBook("002", 1, "ebook@example.com", "");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();
        }

        public static void TestBuyDemoBook(InventoryService inventoryService)
        {
            try
            {


                inventoryService.PurchaseBook("003", 1, "", "");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();
        }

        public static void TestRemoveOutdatedBooks(InventoryService inventoryService)
        {
            List<BaseBook> removedBooks = inventoryService.RemoveOutdatedBooks(5);


            Console.WriteLine("Quantum book store: Removed books:");

            foreach (var book in removedBooks)
            {
                Console.WriteLine($"- {book.Title} ({book.PublishingYear})");
            }


            Console.WriteLine();
        }
    }
}
