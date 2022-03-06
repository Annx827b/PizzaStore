using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Store
    {
       
        static void Main(string[] args)
        {
            {
                Pizza pizza1 = new Pizza("Hawaii", 80, "Ham", "Pineapple", "Cheese");
                Pizza pizza2 = new Pizza("Veggie", 75, "Olives", "Bellpepper", "Mushrooms");
                Pizza pizza3 = new Pizza("House Special", 90, "Kebab", "Chili", "Cheese");

                Toppings extraTopping1 = new Toppings("Pepperoni", 4);
                Toppings extraTopping2 = new Toppings("Tomato", 4);
                Toppings extraTopping3 = new Toppings("Minced Beef", 4);

                Customer customer1 = new Customer("Allan Hansen", 22245678, "allan@hotmail.com", "Hundredemeterskoven 46, 2100 København", 1010);
                Customer customer2 = new Customer("Regitse Sørensen", 33229076, "Rs@gmail.com", "Fantasivej 98, 4000 Roskilde", 1088);
                Customer customer3 = new Customer("Batman", 1122334455, "Iambatman@gmail.com", "Batcave", 1100);

                Order order1 = new Order(pizza1, customer1, extraTopping1, "Order No. 1", 1.1, 40);
                Order order2 = new Order(pizza2, customer2, extraTopping2, "Order No. 2", 1.1, 40);
                Order order3 = new Order(pizza3, customer3, extraTopping3, "Order No. 3", 1.1, 40);

                Console.WriteLine();
                Start();

                #region Methods
                void Start()
                {
                    Console.WriteLine($"Welcome To Big Mamma Pizzaria!");
                    Console.WriteLine();
                    Console.WriteLine($"Press Enter To View The Current MENU");
                    Console.ReadKey();
                    Console.WriteLine();
                    Console.WriteLine($"MENU");
                    Console.WriteLine();
                    Console.WriteLine((pizza1.ToString()));
                    Console.WriteLine((pizza2.ToString()));
                    Console.WriteLine((pizza3.ToString()));
                    Console.WriteLine();
                    Console.WriteLine($"These Are The Extra Toppings Available:");
                    Console.WriteLine();
                    Console.WriteLine((extraTopping1.ToString()));
                    Console.WriteLine((extraTopping2.ToString()));
                    Console.WriteLine((extraTopping3.ToString()));
                    Console.WriteLine();
                    Console.WriteLine($"Press Any Key To Show the ORDER OVERVIEW");
                    Console.ReadKey();
                    Console.WriteLine();
                    Console.WriteLine($"ORDER OVERVIEW");
                    Console.WriteLine();
                    Console.WriteLine($"There Has Been Three New Orders! Press Any Key To See Them!");
                    Console.ReadKey();
                    Console.WriteLine();
                    order1.PrintOrder();
                    Console.WriteLine();
                    order2.PrintOrder();
                    Console.WriteLine();
                    order3.PrintOrder();
                    Console.WriteLine();
                    Console.WriteLine($"To Confirm These Orders, Please Press Enter!");
                    Console.ReadKey();
                    Console.WriteLine();
                    Console.WriteLine((order1.ToString()));
                    Console.WriteLine((order2.ToString()));
                    Console.WriteLine((order3.ToString()));
                    Console.WriteLine();
                    Console.WriteLine($"To See More Information About Each Customer, Press Enter!");
                    Console.WriteLine();
                    Console.ReadKey();
                    Console.WriteLine($"CUSTOMER INFO");
                    Console.WriteLine();
                    Console.WriteLine((customer1.ToString()));
                    Console.WriteLine();
                    Console.WriteLine((customer2.ToString()));
                    Console.WriteLine();
                    Console.WriteLine((customer3.ToString()));
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.ReadKey();
                }
                #endregion
            }
        }
    }
}
  


    

