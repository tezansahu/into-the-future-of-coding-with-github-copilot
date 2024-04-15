class ShoppingCart:

    class CartItem:
        
        def __init__(self, product_id, product_name, price, quantity):
            self.product_id = product_id
            self.product_name = product_name
            self.price = price
            self.quantity = quantity

    def __init__(self):
        self.items = []

    def add_item(self, product_id, product_name, price, quantity):
            existing_item = next((item for item in self.items if item.product_id == product_id), None)

            if existing_item:
                existing_item.quantity += quantity
            else:
                new_item = self.CartItem(product_id, product_name, price, quantity)
                self.items.append(new_item)

    def update_quantity(self, product_id, quantity):
        existing_item = next((item for item in self.items if item.product_id == product_id), None)

        if existing_item:
            existing_item.quantity = quantity

    def remove_item(self, product_id):
        self.items = [item for item in self.items if item.product_id != product_id]

    def calculate_total(self):
        return sum(item.price * item.quantity for item in self.items)

    def get_cart_items(self):
        return self.items.copy()


def main():
    shopping_cart = ShoppingCart()

    shopping_cart.add_item(1, "Product A", 25.99, 2)
    shopping_cart.add_item(2, "Product B", 15.49, 3)

    print("Cart Contents:")
    for item in shopping_cart.get_cart_items():
        print(f"{item.product_name} - Quantity: {item.quantity} - Price: ${item.price:.2f}")

    print(f"Total Price: ${shopping_cart.calculate_total():.2f}")

    shopping_cart.update_quantity(1, 5)

    print("\nUpdated Cart Contents:")
    for item in shopping_cart.get_cart_items():
        print(f"{item.product_name} - Quantity: {item.quantity} - Price: ${item.price:.2f}")

    shopping_cart.remove_item(2)

    print("\nCart Contents After Removing Item:")
    for item in shopping_cart.get_cart_items():
        print(f"{item.product_name} - Quantity: {item.quantity} - Price: ${item.price:.2f}")


if __name__ == "__main__":
    main()
