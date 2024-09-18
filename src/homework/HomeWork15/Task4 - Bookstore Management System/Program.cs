/*
Bookstore Management System Requirements

1. Customer View
Customers can:
Explore available books in the store.
Browse books by categories (e.g., Fiction, Non-Fiction, Science, etc.).
View book details (title, author, price, description, etc.).
Add books to their shopping cart.
Place orders for selected books.
View their own ordered books (order history).

2. Admin View
Administrators have additional privileges:
Manage book inventory:
Add new books to the system.
Update book information (e.g., price, stock quantity, description).
Delete books that are no longer available.
Manage book categories (add, edit, delete).

4. Book Inventory
Each book has the following attributes:
Title
Author(s)
ISBN
Price
Stock quantity
Description
Category (e.g., Fiction, Mystery, Science Fiction, etc.)

5. Shopping Cart
Users can add books to their shopping cart.
Users can remove items from the cart.

6. Order Processing
When a user places an order:
The system deducts the ordered quantity from the book’s stock.
An order confirmation email is sent to the user.
Orders are stored in the txt document(json format) for future reference.

7. Additional Features (Optional)
Search functionality: Users can search for books by title, author, or category.
Pagination: Display books in pages to improve performance.
 */


/*
Ideas:
1. Create an Interface called IStoreItem that is the contract for the Book class that implements it, 
in an attempt to generalize a store item. 
 */

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
