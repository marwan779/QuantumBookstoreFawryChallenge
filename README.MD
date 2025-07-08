# 📚 Quantum Bookstore

A console-based online bookstore simulation built in C# as part of the **Fawry N² Dev Slope #10 Challenge**.

This system models inventory management and purchase flows for different types of books, and is designed to be **extensible** and **testable**.

---

## 🚀 Features

- **Add books** to inventory (PaperBook, EBook, DemoBook)
- **Purchase books** using ISBN, quantity, email, and address
  - PaperBooks are shipped
  - EBooks are emailed
  - DemoBooks are not for sale
- **Remove outdated books** based on a year threshold
- **Full test coverage** via a separate static test class
- **Easily extensible** architecture for adding new book types

---

## 🧱 Book Types

| Type        | Description                              | Supports Purchase? | Notes                        |
|-------------|------------------------------------------|---------------------|------------------------------|
| PaperBook   | Physical books with stock                | ✅ Yes              | Shipped to an address        |
| EBook       | Digital books with file types (e.g., PDF)| ✅ Yes              | Sent to an email             |
| DemoBook    | Showcase or preview books                | ❌ No               | Not for sale                 |

---

## 🧪 Testing

Testing is handled through the `TestCases` static class. It includes:

- Adding books to inventory
- Buying valid and invalid books
- Purchasing with insufficient stock
- Handling outdated books
- Edge cases like duplicate titles with different ISBNs

To run all tests, simply execute the `QuantumBookstoreFullTest` class.

---

## 📌 Design Highlights

- **Polymorphic book handling** via `BaseBook` abstract class
- Clear separation between business logic (`InventoryService`) and testing
- Prints prefixed with `"Quantum book store"` as per requirements


