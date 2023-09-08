using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccessLayer.Entities
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public int Quantity { get; set; }

        // Define a foreign key property for the associated product
        public int ProductId { get; set; }
        public Product Product { get; set; }

        // Define a foreign key property for the shopping cart to which this item belongs
        public int ShoppingCartId { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
    }


    public class Address
    {
        public int AddressId { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        // Define a navigation property for users with this address
        public int UserId { get; set; }
        public User User { get; set; }
    }


    public class Payment
    {
        public int PaymentId { get; set; }
        public string PaymentMethod { get; set; }
        public string TransactionId { get; set; }
        public string BillingInfo { get; set; }

        // Define a foreign key property for the associated order
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }


    public class UserRole
    {
        public int UserRoleId { get; set; }
        public string RoleName { get; set; }

        // Define a navigation property for users with this role
        public ICollection<User> Users { get; set; }
    }


    public class ShoppingCart
    {
        public int ShoppingCartId { get; set; }

        // Define a navigation property for shopping cart items
        public ICollection<ShoppingCartItem> ShoppingCartItems { get; set; }

        // Define a foreign key property for the user who owns the shopping cart
        public int UserId { get; set; }
        public User User { get; set; }
    }


    public class Review
    {
        public int ReviewId { get; set; }
        public string ReviewText { get; set; }
        public int Rating { get; set; }

        // Define a foreign key property for the associated product
        public int ProductId { get; set; }
        public Product Product { get; set; }

        // Define a foreign key property for the user who submitted the review
        public int UserId { get; set; }
        public User User { get; set; }
    }


    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        // Define foreign key properties for the order and associated product
        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }


    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public string OrderStatus { get; set; }

        // Define a foreign key property for the user who placed the order
        public int UserId { get; set; }
        public User User { get; set; }

        // Define a navigation property for order items
        public ICollection<OrderItem> OrderItems { get; set; }
    }

    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }

        // Define other user profile properties as needed

        // Define a navigation property for user roles
        public ICollection<UserRole> UserRoles { get; set; }

        // Define a navigation property for orders
        public ICollection<Order> Orders { get; set; }
    }


    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        // Define a navigation property for products
        public ICollection<Product> Products { get; set; }
    }


    public class Product
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public DateTime ReleaseDate { get; set; }

        // Define a foreign key property for the category
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        // Define a navigation property for reviews
        public ICollection<Review> Reviews { get; set; }
    }

}
