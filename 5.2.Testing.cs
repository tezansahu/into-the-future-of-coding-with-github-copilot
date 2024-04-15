using System;
using System.Collections.Generic;
using System.Linq;

public class ShoppingCart
{
    public class CartItem
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }

    private List<CartItem> items;

    public ShoppingCart()
    {
        items = new List<CartItem>();
    }


    public void AddItem(int productId, string productName, decimal price, int quantity)
    {
        var existingItem = items.FirstOrDefault(item => item.ProductId == productId);

        if (existingItem != null)
        {
            existingItem.Quantity += quantity;
        }
        else
        {
            var newItem = new CartItem
            {
                ProductId = productId,
                ProductName = productName,
                Price = price,
                Quantity = quantity
            };

            items.Add(newItem);
        }
    }

    public void UpdateQuantity(int productId, int quantity)
    {
        var existingItem = items.FirstOrDefault(item => item.ProductId == productId);

        if (existingItem != null)
        {
            existingItem.Quantity = quantity;
        }
    }

    public void RemoveItem(int productId)
    {
        var itemToRemove = items.FirstOrDefault(item => item.ProductId == productId);

        if (itemToRemove != null)
        {
            items.Remove(itemToRemove);
        }
    }

    public decimal CalculateTotal()
    {
        return items.Sum(item => item.Price * item.Quantity);
    }

    public List<CartItem> GetCartItems()
    {
        return items.ToList();
    }
}

class Program
{
    static void Main()
    {

        var shoppingCart = new ShoppingCart();

        shoppingCart.AddItem(1, "Product A", 25.99m, 2);
        shoppingCart.AddItem(2, "Product B", 15.49m, 3);

        Console.WriteLine("Cart Contents:");
        foreach (var item in shoppingCart.GetCartItems())
        {
            Console.WriteLine($"{item.ProductName} - Quantity: {item.Quantity} - Price: {item.Price:C}");
        }

        Console.WriteLine($"Total Price: {shoppingCart.CalculateTotal():C}");

        shoppingCart.UpdateQuantity(1, 5);

        Console.WriteLine("\nUpdated Cart Contents:");
        foreach (var item in shoppingCart.GetCartItems())
        {
            Console.WriteLine($"{item.ProductName} - Quantity: {item.Quantity} - Price: {item.Price:C}");
        }

        shoppingCart.RemoveItem(2);

        Console.WriteLine("\nCart Contents After Removing Item:");
        foreach (var item in shoppingCart.GetCartItems())
        {
            Console.WriteLine($"{item.ProductName} - Quantity: {item.Quantity} - Price: {item.Price:C}");
        }
    }
}
