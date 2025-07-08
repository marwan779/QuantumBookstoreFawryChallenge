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

                Console.WriteLine($"Paid Amount = {paid:C}");
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
                double paid = inventoryService.PurchaseBook("002", 1, "ebook@example.com", "");

                Console.WriteLine($"Paid Amount = {paid:C}");
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

        public static void TestBuyPaperBookInsufficientStock(InventoryService inventoryService)
        {
            try
            {

                inventoryService.PurchaseBook("001", 20, "user@example.com", "123 Main St");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }

            Console.WriteLine();
        }

        public static void TestBuyMultipleEBooks(InventoryService inventoryService)
        {
            try
            {

                inventoryService.PurchaseBook("002", 2, "user@example.com", "");
            }

            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            Console.WriteLine();
        }

        public static void TestBuyInvalidISBN(InventoryService inventoryService)
        {
            try
            {


                inventoryService.PurchaseBook("999", 1, "user@example.com", "some address");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
            Console.WriteLine();
        }

        public static void TestAddAndRemoveSingleOutdatedBook(InventoryService inventoryService)
        {
            inventoryService.AddBook(new PaperBook("004", "Old Book", 2000, 10, 5));
            List<BaseBook> removed = inventoryService.RemoveOutdatedBooks(10); // Assuming current year is 2025

            Console.WriteLine("Removed books:");
            foreach (var book in removed)
            {
                Console.WriteLine($"- {book.Title} ({book.PublishingYear})");
            }


            Console.WriteLine();
        }

        public static void TestBuyBooksWithSimilarTitles(InventoryService inventoryService)
        {
            inventoryService.AddBook(new PaperBook("005", "C# Basics Advanced", 2021, 60, 5));
            inventoryService.AddBook(new EBook("006", "C# Basics Intro", 2023, 25, "epub"));

            try
            {
                inventoryService.PurchaseBook("005", 1, "user@example.com", "Shipping Lane");
                inventoryService.PurchaseBook("006", 1, "ebook@example.com", "");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }

            Console.WriteLine();
        }
    }
}
