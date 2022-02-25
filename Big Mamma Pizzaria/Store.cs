using System;

namespace PizzaStore
{
    public class Store
    {
        public static void Main(string[] args)
        {
            Pizza pizza1 = new Pizza("Hawaii", 80, "Ham", "Pineapple", "Cheese");
            Pizza pizza2 = new Pizza("Veggie", 75, "Olives", "Chili", "Mushrooms");
            Pizza pizza3 = new Pizza("House Special", 90, "Kebab", "Chili", "Cheese");

            Toppings extraTopping1 = new Toppings("Pepperoni", 4);
            Toppings extraTopping2 = new Toppings("Tomato", 4);
            Toppings extraTopping3 = new Toppings("Minced Beef", 4);
            Toppings extraTopping4 = new Toppings("Chicken", 4);

            Customer customer1 = new Customer("Allan Hansen", 22245678,"allan@hotmail.com", "Skovvej 46, 4000 Roskilde", 1010);
            Customer customer2 = new Customer("Regitse Sørensen", 33229076, "Rs@gmail.com", "Rolighedsstræde, 4000 Roskilde", 1088);
            Customer customer3 = new Customer("Batman", 1122334455, "Iambatman@gmail.com", "Batcave", 1100);


            Order order1 = new Order();
            Order order2 = new Order();
            Order order3 = new Order();

            Reciept reciept1 = new Reciept();
            Reciept reciept2 = new Reciept();
            Reciept reciept3 = new Reciept();

            Console.WriteLine($"Welcome to Big Mamma Pizzaria. Press any key to get see our Pizzas");
            Console.ReadLine();
            pizza1.PrintPizzaInfo();
            pizza2.PrintPizzaInfo();
            pizza3.PrintPizzaInfo();
            Console.WriteLine();
            Console.WriteLine($"There has been an order!");
            Console.WriteLine();
            customer1.PrintCustomerInfo();
            
        }
    }
}
