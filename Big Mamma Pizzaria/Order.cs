using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PizzaStore
{
    public class Order
    {
        private string _orderName;
        private double _tax;
        private int _delivery;
        private Pizza _pizza;
        private Customer _customer;
        private Toppings _toppings;

        #region Constructor
        public Order(Pizza pizza, Customer customer, Toppings toppings,string orderName, double tax, int delivery)
        {
            _orderName = orderName;
            _tax = tax;
            _delivery = delivery;
            _pizza = pizza;
            _customer = customer;
            _toppings = toppings;
        }
        #endregion

        #region Properties
       
        public string OrderName
        { get { return _orderName; } }

        public double Tax
        { get { return _tax; } }
       
        public int Delivery
        { get { return _delivery;} }

        #endregion


        #region Methods

        public void PrintOrder()
        {
            Console.WriteLine($"{_orderName} : {_pizza.NameOfPizza}, ({_pizza.Topping1}, {_pizza.Topping2}, {_pizza.Topping3}) with Extra Topping: {_toppings.nameOfExtraTopping}.");
            Console.WriteLine($"Ordered by {_customer.Name} - ID NUMBER: {_customer.IdNumber}");
            Console.WriteLine($"Total Price for order including delivery and taxes is: {CalculateTotalPrice()} DKK");
        }
        
        public double CalculateTotalPrice()
        {
            double totalPrice = (_pizza.PrizeOfPizza + _toppings.priceOfExtraTopping + Delivery) * Tax;
            return totalPrice;
        }
        public override string ToString()
        { 
            return $"{_orderName} with {_customer.IdNumber} has been confirmed at {DateTime.Now}";
        }

    }
        #endregion
    }







