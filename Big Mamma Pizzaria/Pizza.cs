using System;
namespace Big_Mamma_Pizzaria
{
    public class Pizza
    {
        #region Instance fields

        private string _nameOfPizza;
        private double _prizeOfPizza;
        private string _topping1;
        private string _topping2;
        private string _topping3;

        #endregion

        #region Constructor
        public Pizza(string nameOfPizza, double priceOfPizza, string topping1, string topping2, string topping3)
        {
            _nameOfPizza = nameOfPizza;
            _prizeOfPizza = priceOfPizza;
            _topping1 = topping1;
            _topping2 = topping2;
            _topping3 = topping3;
        }

        #endregion
        
        #region Properties
        public string NameOfPizza
        { get { return _nameOfPizza; } }

        public double PrizeOfPizza
        { get { return _prizeOfPizza; } }

        public string Topping1
        { get { return _topping1; } }

        public string Topping2
        { get { return _topping2; } }

        public string Topping3
        { get { return _topping3; } }

        #endregion

        #region Methods
        public void PrintPizzaInfo()
        {
            Console.WriteLine($"{_nameOfPizza} (Toppings: {_topping1}, {_topping2} and {_topping3}) - {_prizeOfPizza} DKK");
        }

        #endregion
    }
}
