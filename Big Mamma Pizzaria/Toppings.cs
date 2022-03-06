using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        {
            get { return _nameOfExtraTopping; }
        }

        public int priceOfExtraTopping
        { get 
            { return _priceOfExtraTopping; } 
        }
        #endregion
      
        #region Methods
  public override string ToString()
        {
            return $"{_nameOfExtraTopping} - {_priceOfExtraTopping} DKK";
        }

        #endregion
    }
}
