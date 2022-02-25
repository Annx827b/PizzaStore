using System;

namespace PizzaStore
{
    public class Toppings
    {
        #region Instance Fields
        string _nameOfExtraTopping;
        int _priceOfExtraTopping;
        #endregion

        #region Constructor
        public Toppings(string nameOfExtraTopping, int priceOfExtraTopping)
        {
            _nameOfExtraTopping = nameOfExtraTopping;
            _priceOfExtraTopping = 4;
        }
        #endregion
        
        #region Properties
        public string nameOfExtraTopping 
        { get { return nameOfExtraTopping; } }

        public int priceOfExtraTopping
        { get { return priceOfExtraTopping; } }
        #endregion

        #region Methods
        public void AddExtraPepperoni()
        {
            int extraTopping1 = 0;
            extraTopping1 = +1;
        }

        #endregion
    }
}
