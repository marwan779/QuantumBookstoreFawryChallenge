using QuantumBookstoreFawryChallenge.Services;
using QuantumBookstoreFawryChallenge.Testing;

namespace QuantumBookstoreFawryChallenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            InventoryService inventoryService = new InventoryService();

            TestCases.TestAddBooks(inventoryService);
            TestCases.TestBuyPaperBook(inventoryService);
            TestCases.TestBuyEBook(inventoryService);
            TestCases.TestBuyDemoBook(inventoryService);
            TestCases.TestRemoveOutdatedBooks(inventoryService);
            TestCases.TestBuyPaperBookInsufficientStock(inventoryService);
            TestCases.TestBuyMultipleEBooks(inventoryService);
            TestCases.TestBuyInvalidISBN(inventoryService);
            TestCases.TestAddAndRemoveSingleOutdatedBook(inventoryService);
            TestCases.TestBuyBooksWithSimilarTitles(inventoryService);
        }
    }
}
