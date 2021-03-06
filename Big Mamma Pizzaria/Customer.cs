using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Customer
    {
        #region Instance Fields
        string _name;
        int _phoneNumber;
        string _mail;
        string _adress;
        int _idNumber;
        #endregion

        #region Constructor
        public Customer(string name, int phoneNumber, string mail, string adress, int idNumber)
        {
            _name = name;
            _phoneNumber = phoneNumber;
            _mail = mail;
            _adress = adress;
            _idNumber = idNumber;
        }
        #endregion

        #region Properties

        public string Name
        { get { return _name; } }

        public int PhoneNumber
        { get { return _phoneNumber; } }

        public string Mail 
        { get { return _mail; } }

        public string Adress
        { get { return _adress; } }

        public int IdNumber
        { get { return _idNumber; } }
        #endregion

        #region Methods
           public override string ToString()
        {
            return $"Name: {_name}. Phone Number: {_phoneNumber}. Mail: {_mail}. Adress: {_adress}. Id-Number: {_idNumber}.";
        }

        #endregion
    }
}
